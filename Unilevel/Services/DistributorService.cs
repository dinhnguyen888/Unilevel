using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Unilevel.DTOs;
using Unilevel.Models;

public class DistributorService
{
    private readonly AppDbContext _context;
    private readonly RoleManager<Role> _roleManager;
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    public DistributorService(AppDbContext context, UserManager<User> userManager, RoleManager<Role> roleManager, IConfiguration configuration)
    {
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
        _configuration = configuration;
    }

    // Thêm Distributor
    public async Task<Distributor> CreateDistributorAsync(DistributorDTO dto)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            // Tạo user mới
            var user = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = dto.FullName,
                Email = dto.Email,
                Address = dto.Address,
                PhoneNumber = dto.PhoneNumber
            };

            var passwordSetting = _configuration.GetSection("PasswordDefault");
            string newPassword = passwordSetting["Pass"];
            var createResult = await _userManager.CreateAsync(user, newPassword);

            if (!createResult.Succeeded)
            {
                throw new Exception(string.Join("; ", createResult.Errors.Select(e => e.Description)));
            }

            // Gán role cho user
            var roleAssignResult = await _userManager.AddToRoleAsync(user, "distributorOMTL");
            if (!roleAssignResult.Succeeded)
            {
                throw new InvalidOperationException($"Failed to assign role distributorOMTL to user. Errors: {string.Join(", ", roleAssignResult.Errors.Select(e => e.Description))}");
            }

            // Tạo Distributor mới
            var distributor = new Distributor
            {
                UserId = user.Id,
                SaleManagementId = dto.SaleManagement
            };

            await _context.Distributor.AddAsync(distributor);

            // Thêm vào bảng SaleDistributor nếu có
            if (dto.Sales != null && dto.Sales.Any())
            {
                var saleDistributors = dto.Sales.Select(saleId => new SaleDistributor
                {
                    DistributorId = distributor.UserId,
                    SaleStaffId = saleId
                }).ToList();

                var invalidSaleStaffIds = dto.Sales.Where(saleId => !_context.SaleStaff.Any(ss => ss.UserId == saleId)).ToList();
                if (invalidSaleStaffIds.Any())
                {
                    throw new Exception($"The following SaleStaffIds do not exist: {string.Join(", ", invalidSaleStaffIds)}");
                }
                await _context.SaleDistributor.AddRangeAsync(saleDistributors);
            }

            await _context.SaveChangesAsync();
            await transaction.CommitAsync();

            return distributor;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    // Cập nhật Distributor
    public async Task<bool> UpdateDistributorAsync(string id, DistributorDTO dto)
    {
        var distributor = await _context.Distributor
            .Include(d => d.SaleDistributors)
            .FirstOrDefaultAsync(d => d.UserId == id);

        if (distributor == null) return false;

        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            // Cập nhật thông tin User
            var user = await _context.Users.FindAsync(id);
            if (user == null) return false;

            user.UserName = dto.FullName;
            user.Email = dto.Email;
            user.Address = dto.Address;
            user.PhoneNumber = dto.PhoneNumber;

            // Cập nhật thông tin Distributor
            distributor.SaleManagementId = dto.SaleManagement;

            // Cập nhật SaleDistributor
            var existingSales = distributor.SaleDistributors.Select(sd => sd.SaleStaffId).ToList();
            var newSales = dto.Sales ?? new List<string>();

            // Xóa các SaleDistributor không còn tồn tại
            var salesToRemove = distributor.SaleDistributors.Where(sd => !newSales.Contains(sd.SaleStaffId)).ToList();
            _context.SaleDistributor.RemoveRange(salesToRemove);

            // Thêm mới các SaleDistributor
            var salesToAdd = newSales.Where(saleId => !existingSales.Contains(saleId))
                                     .Select(saleId => new SaleDistributor
                                     {
                                         DistributorId = distributor.UserId,
                                         SaleStaffId = saleId
                                     }).ToList();
            await _context.SaleDistributor.AddRangeAsync(salesToAdd);

            await _context.SaveChangesAsync();
            await transaction.CommitAsync();

            return true;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    // Xóa Distributor
    public async Task<bool> DeleteDistributorAsync(string id)
    {
        var distributor = await _context.Distributor.FindAsync(id);
        if (distributor == null) return false;

        // Xóa SaleDistributor liên quan
        var saleDistributors = _context.SaleDistributor.Where(sd => sd.DistributorId == id).ToList();
        _context.SaleDistributor.RemoveRange(saleDistributors);

        // Xóa Distributor
        _context.Distributor.Remove(distributor);

        // Xóa User liên quan
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
        }

        await _context.SaveChangesAsync();
        return true;
    }

    // Lấy danh sách tất cả Distributor
    public async Task<List<DistributorDTO>> GetAllDistributorsAsync()
    {
        return await _context.Distributor
            .Include(d => d.SaleDistributors)
            .Select(d => new DistributorDTO
            {
                Id = d.UserId,
                FullName = d.User.UserName,
                Email = d.User.Email,
                Address = d.User.Address,
                PhoneNumber = d.User.PhoneNumber,
                SaleManagement = d.SaleManagementId,
                Sales = d.SaleDistributors.Select(sd => sd.SaleStaffId).ToList()
            })
            .ToListAsync();
    }

    // Lấy Distributor theo Id
    public async Task<DistributorDTO?> GetDistributorByIdAsync(string id)
    {
        var distributor = await _context.Distributor
            .Include(d => d.SaleDistributors)
            .FirstOrDefaultAsync(d => d.UserId == id);

        if (distributor == null) return null;

        var user = await _context.Users.FindAsync(id);
        if (user == null) return null;

        return new DistributorDTO
        {
            FullName = user.UserName,
            Email = user.Email,
            Address = user.Address,
            PhoneNumber = user.PhoneNumber,
            SaleManagement = distributor.SaleManagementId,
            Sales = distributor.SaleDistributors.Select(sd => sd.SaleStaffId).ToList()
        };
    }
}
