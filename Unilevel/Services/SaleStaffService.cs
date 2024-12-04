using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Unilevel.DTOs;
using Unilevel.Models;

public class SaleStaffService
{
    private readonly AppDbContext _context;
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly IConfiguration _configuration;

    public SaleStaffService(AppDbContext context, UserManager<User> userManager, RoleManager<Role> roleManager, IConfiguration configuration)
    {
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
        _configuration = configuration;
    }


    // Tao Nhan vien moi
    public async Task<SaleStaff> CreateSaleStaffAsync(SaleStaffDTO dto)
    {
        // Tao transaction
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            if (!await _roleManager.RoleExistsAsync(dto.RoleId))
            {
                throw new ArgumentException($"Role '{dto.RoleId}' Khong ton tai. ");
            }
            // Kiểm tra InferiorId có tồn tại trong UserManager của Identity
            if (dto.InferiorId != null && dto.InferiorId.Any())
            {
                foreach (var inferiorId in dto.InferiorId)
                {
                    var userExists = await _userManager.FindByIdAsync(inferiorId);
                    if (userExists == null)
                    {
                        throw new ArgumentException($"Inferior with ID {inferiorId} does not exist in the system.");
                    }
                }
            }

            var saleStaff = new SaleStaff
            {
                Id = Guid.NewGuid().ToString(),
                UserName = dto.FullName,
                Email = dto.Email,
                ManagerId = dto.ManagerId,
                AreaId = dto.AreaId, 
                IsActive = dto.IsActive ?? true,
                JoinDate = DateTime.UtcNow
            };

            await _context.SaleStaff.AddAsync(saleStaff);
            await _context.SaveChangesAsync();

            // Gan managerID cho cap duoi
            if (dto.InferiorId != null && dto.InferiorId.Any())
            {
                var inferiors = await _context.SaleStaff
                    .Where(s => dto.InferiorId.Contains(s.Id))
                    .ToListAsync();

                foreach (var inferior in inferiors)
                {
                    inferior.ManagerId = saleStaff.Id;
                }

                await _context.SaveChangesAsync();
            }
            
            var roleAssignResult = await _userManager.AddToRoleAsync(saleStaff, dto.RoleId);
            if (!roleAssignResult.Succeeded)
            {
                throw new InvalidOperationException($"Failed to assign role {dto.RoleId} to user. Errors: {string.Join(", ", roleAssignResult.Errors.Select(e => e.Description))}");
            }

            var passwordSetting = _configuration.GetSection("PasswordDefault");
            string newPassword = passwordSetting["Pass"];
            var addPasswordResult = await _userManager.AddPasswordAsync(saleStaff, "Abc123@");
            if (!addPasswordResult.Succeeded)
            {
                throw new InvalidOperationException($"Failed to set password for user with email {dto.Email}. Errors: {string.Join(", ", addPasswordResult.Errors.Select(e => e.Description))}");
            }

            // Commit transaction
            await transaction.CommitAsync();

            return saleStaff;
        }
        catch (Exception ex)
        {
            // Rollback transaction neu bi loi
            await transaction.RollbackAsync();

            // Log loi
            Console.WriteLine($"Error creating SaleStaff: {ex.Message}");
            throw;
        }
    }



    // Cap nhat thong tin 
    public async Task<bool> UpdateSaleStaffAsync(string id, SaleStaffDTO dto)
    {
        var saleStaff = await _context.SaleStaff.FindAsync(id);
        if (saleStaff == null) return false;

        saleStaff.UserName = dto.FullName;
        saleStaff.Email = dto.Email;
        saleStaff.ManagerId = dto.ManagerId;
        saleStaff.IsActive = dto.IsActive;
        saleStaff.ManagerId = dto.ManagerId;
        if (dto.InferiorId != null && dto.InferiorId.Any())
        {
            var inferiors = await _context.SaleStaff
                .Where(s => dto.InferiorId.Contains(s.Id))
                .ToListAsync();

            foreach (var inferior in inferiors)
            {
                
                inferior.ManagerId = saleStaff.Id;
            }

            await _context.SaveChangesAsync();
        }
        try
        {
            // Lay role
            var currentRoles = await _userManager.GetRolesAsync(saleStaff);

            // Check
            if (!currentRoles.Contains(dto.RoleId))
            {
                // Xoa role cu
                var removeRolesResult = await _userManager.RemoveFromRolesAsync(saleStaff, currentRoles);
                if (!removeRolesResult.Succeeded)
                {
                    throw new InvalidOperationException($"Xoa Role that bai: {string.Join(", ", removeRolesResult.Errors.Select(e => e.Description))}");
                }

                // Gan role moi
                var addRoleResult = await _userManager.AddToRoleAsync(saleStaff, dto.RoleId);
                if (!addRoleResult.Succeeded)
                {
                    throw new InvalidOperationException($"Gan role moi that bai {dto.RoleId}. Errors: {string.Join(", ", addRoleResult.Errors.Select(e => e.Description))}");
                }
            }

            await _context.SaveChangesAsync();
            return true;
        }
        catch (DbUpdateConcurrencyException)
        {
            throw;
        }
    }


    // Xoa SaleStaff
    public async Task<bool> DeleteSaleStaffAsync(string id)
    {
        var saleStaff = await _context.SaleStaff.FindAsync(id);
        if (saleStaff == null) return false;

        _context.SaleStaff.Remove(saleStaff);
        await _context.SaveChangesAsync();
        return true;
    }

    // Lay danh sach SaleStaff
    public async Task<List<SaleStaffDTO>> GetAllSaleStaffAsync()
    {
        var saleStaffs = await _context.SaleStaff
            .Include(s => s.SaleDistributors)
            .ToListAsync();

        var saleStaffDTOs = new List<SaleStaffDTO>();

        foreach (var saleStaff in saleStaffs)
        {
            // Lay Role tu UserManager
            var roles = await _userManager.GetRolesAsync(saleStaff);

            saleStaffDTOs.Add(new SaleStaffDTO
            {
                Id = saleStaff.Id,
                FullName = saleStaff.UserName,
                Email = saleStaff.Email,
                RoleId = roles.FirstOrDefault(), 
                ManagerId = saleStaff.ManagerId,
                AreaId = saleStaff.AreaId,

                IsActive = saleStaff.IsActive,
            });
        }

        return saleStaffDTOs;
    }


    //public async Task<SaleStaffDTO?> GetSaleStaffByIdAsync(string id)
    //{
    //    var saleStaff = await _context.SaleStaff
    //        .Include(s => s.SaleDistributors) // Bao gồm các SaleDistributor
    //        .FirstOrDefaultAsync(s => s.Id == id);

    //    if (saleStaff == null) return null;

    //    // Lấy Role từ UserManager
    //    var roles = await _userManager.GetRolesAsync(saleStaff);

    //    return new SaleStaffDTO
    //    {
    //        Id = saleStaff.Id,
    //        FullName = saleStaff.UserName,
    //        Email = saleStaff.Email,
    //        RoleId = roles.FirstOrDefault(), // Lấy Role đầu tiên (giả sử mỗi user có 1 role)
    //        ManagerId = saleStaff.ManagerId,
    //        IsActive = saleStaff.IsActive,
    //    };
    //}

}
