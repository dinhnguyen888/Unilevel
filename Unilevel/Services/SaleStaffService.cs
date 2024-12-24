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

    // Tao nhan vien moi
    public async Task<SaleStaff> CreateSaleStaffAsync(SaleStaffDTO dto)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            // Kiem tra Role
            if (!await _roleManager.RoleExistsAsync(dto.RoleId))
            {
                throw new ArgumentException($"Role '{dto.RoleId}' khong ton tai.");
            }

            // Tao User moi
            var user = new User
            {
                UserName = dto.FullName,
                Email = dto.Email,
                AreaId = dto.AreaId,
                JoinDate = DateTime.UtcNow,
                IsActive = dto.IsActive ?? true,
            };
            var passwordSetting = _configuration.GetSection("PasswordDefault");
            string newPassword = passwordSetting["Pass"];
            var userResult = await _userManager.CreateAsync(user, newPassword);
            if (!userResult.Succeeded)
            {
                throw new InvalidOperationException($"Loi khi tao User: {string.Join(", ", userResult.Errors.Select(e => e.Description))}");
            }

            // Gan Role
            var roleAssignResult = await _userManager.AddToRoleAsync(user, dto.RoleId);
            if (!roleAssignResult.Succeeded)
            {
                throw new InvalidOperationException($"Loi khi gan Role: {string.Join(", ", roleAssignResult.Errors.Select(e => e.Description))}");
            }

            // Tao SaleStaff va lien ket voi User
            var saleStaff = new SaleStaff
            {
                UserId = user.Id,
                ManagerId = dto.ManagerId
            };

            await _context.SaleStaff.AddAsync(saleStaff);
            await _context.SaveChangesAsync();

            // Gan ManagerId cho cap duoi neu co
            if (dto.InferiorId != null && dto.InferiorId.Any())
            {
                var inferiors = await _context.SaleStaff
                    .Where(s => dto.InferiorId.Contains(s.UserId))
                    .ToListAsync();

                foreach (var inferior in inferiors)
                {
                    inferior.ManagerId = saleStaff.UserId;
                }

                await _context.SaveChangesAsync();
            }

            await transaction.CommitAsync();
            return saleStaff;
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            Console.WriteLine($"Loi khi tao SaleStaff: {ex.Message}");
            throw;
        }
    }

    // Cap nhat thong tin SaleStaff
    public async Task<bool> UpdateSaleStaffAsync(string userId, SaleStaffDTO dto)
    {
        var saleStaff = await _context.SaleStaff.FirstOrDefaultAsync(s => s.UserId == userId);
        if (saleStaff == null) return false;

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) return false;

        // Cap nhat thong tin User
        user.UserName = dto.FullName;
        user.Email = dto.Email;
        user.AreaId = dto.AreaId;
        user.IsActive = dto.IsActive;

        var userUpdateResult = await _userManager.UpdateAsync(user);
        if (!userUpdateResult.Succeeded)
        {
            throw new InvalidOperationException($"Loi khi cap nhat User: {string.Join(", ", userUpdateResult.Errors.Select(e => e.Description))}");
        }

        // Cap nhat thong tin SaleStaff
        saleStaff.ManagerId = dto.ManagerId;
        if (dto.InferiorId != null && dto.InferiorId.Any())
        {
            var inferiors = await _context.SaleStaff
                .Where(s => dto.InferiorId.Contains(s.UserId))
                .ToListAsync();

            foreach (var inferior in inferiors)
            {
                inferior.ManagerId = saleStaff.UserId;
            }
            await _context.SaveChangesAsync();
        }

        // Cap nhat Role neu can
        var currentRoles = await _userManager.GetRolesAsync(user);
        if (!currentRoles.Contains(dto.RoleId))
        {
            var removeRolesResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
            if (!removeRolesResult.Succeeded)
            {
                throw new InvalidOperationException($"Loi khi xoa Role: {string.Join(", ", removeRolesResult.Errors.Select(e => e.Description))}");
            }

            var addRoleResult = await _userManager.AddToRoleAsync(user, dto.RoleId);
            if (!addRoleResult.Succeeded)
            {
                throw new InvalidOperationException($"Loi khi them Role: {string.Join(", ", addRoleResult.Errors.Select(e => e.Description))}");
            }
        }

        await _context.SaveChangesAsync();
        return true;
    }

    // Xoa SaleStaff
    public async Task<bool> DeleteSaleStaffAsync(string userId)
    {
        var saleStaff = await _context.SaleStaff.FirstOrDefaultAsync(s => s.UserId == userId);
        if (saleStaff == null) return false;

        var user = await _userManager.FindByIdAsync(userId);
        if (user != null)
        {
            var deleteUserResult = await _userManager.DeleteAsync(user);
            if (!deleteUserResult.Succeeded)
            {
                throw new InvalidOperationException($"Loi khi xoa User: {string.Join(", ", deleteUserResult.Errors.Select(e => e.Description))}");
            }
        }

        _context.SaleStaff.Remove(saleStaff);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<SaleStaffDTO>> GetAllSaleStaffAsync()
    {
        var saleStaffs = await _context.SaleStaff
            .Include(s => s.SaleDistributors)
            .Include(u => u.User)
            .ToListAsync();

        var saleStaffDTOs = new List<SaleStaffDTO>();

        foreach (var saleStaff in saleStaffs)
        {
            // Lay Role tu UserManager
            var roles = await _userManager.GetRolesAsync(saleStaff.User);

            saleStaffDTOs.Add(new SaleStaffDTO
            {
                Id = saleStaff.UserId,
                FullName = saleStaff.User.UserName,
                Email = saleStaff.User.Email,
                RoleId = roles.FirstOrDefault(),
                ManagerId = saleStaff.ManagerId,
                AreaId = saleStaff.User.AreaId,

                IsActive = saleStaff.User.IsActive,
            });
        }

        return saleStaffDTOs;
    }
}
