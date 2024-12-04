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


    // Them
    public async Task<Distributor> CreateDistributorAsync(DistributorDTO dto)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            // Tao Distributor moi
            var distributor = new Distributor
            {
                Id = Guid.NewGuid().ToString(),
                UserName = dto.FullName,
                Email = dto.Email,
                SaleManagementId = dto.SaleManagement,
                Address = dto.Address,
                PhoneNumber = dto.PhoneNumber,
            };
            var passwordSetting = _configuration.GetSection("PasswordDefault");
            string newPassword = passwordSetting["Pass"];
            var createResult = await _userManager.CreateAsync(distributor, newPassword);
            if (!createResult.Succeeded)
            {
                throw new Exception(string.Join("; ", createResult.Errors.Select(e => e.Description)));
            }

            // Luu
            var roleAssignResult = await _userManager.AddToRoleAsync(distributor, "distributorOMTL");
            if (!roleAssignResult.Succeeded)
            {
                throw new InvalidOperationException($"Failed to assign role {dto} to user. Errors: {string.Join(", ", roleAssignResult.Errors.Select(e => e.Description))}");
            }
            
            await _context.SaveChangesAsync();

            // Them bang join
            if (dto.Sales != null && dto.Sales.Any())
            {
                var saleDistributors = dto.Sales.Select(saleId => new SaleDistributor
                {
                    DistributorId = distributor.Id,
                    SaleStaffId = saleId
                }).ToList();
                var invalidSaleStaffIds = dto.Sales.Where(saleId => !_context.SaleStaff.Any(ss => ss.Id == saleId)).ToList();
                if (invalidSaleStaffIds.Any())
                {
                    throw new Exception($"The following SaleStaffIds do not exist: {string.Join(", ", invalidSaleStaffIds)}");
                }
                await _context.SaleDistributor.AddRangeAsync(saleDistributors);
                await _context.SaveChangesAsync();
            }
      
            await transaction.CommitAsync();
            return distributor;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }


    // Cap nhat
    public async Task<bool> UpdateDistributorAsync(string id, DistributorDTO dto)
    {
        var distributor = await _context.Distributor
            .Include(d => d.SaleDistributors)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (distributor == null) return false;

        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            distributor.UserName = dto.FullName;
            distributor.Email = dto.Email;
            distributor.SaleManagementId = dto.SaleManagement;
            distributor.Address = dto.Address;
            distributor.PhoneNumber = dto.PhoneNumber;

            var existingSales = distributor.SaleDistributors.Select(sd => sd.SaleStaffId).ToList();
            var newSales = dto.Sales ?? new List<string>();

            // Xoa distributor khong con trong danh sach
            var salesToRemove = distributor.SaleDistributors.Where(sd => !newSales.Contains(sd.SaleStaffId)).ToList();
            _context.SaleDistributor.RemoveRange(salesToRemove);

            // Them distributor moi
            var salesToAdd = newSales.Where(saleId => !existingSales.Contains(saleId))
                                     .Select(saleId => new SaleDistributor
                                     {
                                         DistributorId = distributor.Id,
                                         SaleStaffId = saleId
                                     }).ToList();
            await _context.SaleDistributor.AddRangeAsync(salesToAdd);

            // Luu
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


    // Xoa
    public async Task<bool> DeleteDistributorAsync(string id)
    {
        var distributor = await _context.Distributor.FindAsync(id);
        if (distributor == null) return false;

        // Xoa bang join lien quan
        var saleDistributors = _context.SaleDistributor.Where(sd => sd.DistributorId == id).ToList();
        _context.SaleDistributor.RemoveRange(saleDistributors);

        // Xoa Distributor
        _context.Distributor.Remove(distributor);
        await _context.SaveChangesAsync();
        return true;
    }


    // Lay danh sach tat ca distributor
    public async Task<List<DistributorDTO>> GetAllDistributorsAsync()
    {
        return await _context.Distributor
            .Include(d => d.SaleDistributors)
            .Select(d => new DistributorDTO
            {
                FullName = d.UserName,
                Email = d.Email,
                Address = d.Address,
                PhoneNumber = d.PhoneNumber,
                SaleManagement = d.SaleManagementId,
                Sales = d.SaleDistributors.Select(sd => sd.SaleStaffId).ToList()
            })
            .ToListAsync();
    }

    // Lay theo Id
    public async Task<DistributorDTO?> GetDistributorByIdAsync(string id)
    {
        var distributor = await _context.Distributor
            .Include(d => d.SaleDistributors)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (distributor == null) return null;

        return new DistributorDTO
        {
            FullName = distributor.UserName,
            Email = distributor.Email,
            Address = distributor.Address,
            PhoneNumber = distributor.PhoneNumber,
            SaleManagement = distributor.SaleManagementId,
            Sales = distributor.SaleDistributors.Select(sd => sd.SaleStaffId).ToList()
        };
    }
}
