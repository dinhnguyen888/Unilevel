using Microsoft.EntityFrameworkCore;
using Unilevel.Models;

public class PermissionService
{
    private readonly AppDbContext _dbContext;

    public PermissionService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // Lấy danh sách tất cả các permission
    public async Task<List<PermissionDTO>> GetAllPermissionsAsync()
    {
        return await _dbContext.Permission
            .Select(p => new PermissionDTO
            {
                PermissionId = p.PermissionId,
                PermissionName = p.PermissionName
            }).ToListAsync();
    }

    // Gán permissions cho role
    public async Task<string> AssignPermissionsToRoleAsync(AssignPermissionDTO dto)
    {
        var role = await _dbContext.Roles
            .Include(r => r.RolePermissions)
            .FirstOrDefaultAsync(r => r.Id == dto.RoleId);

        if (role == null)
        {
            throw new Exception("Role not found");
        }

        var permissions = await _dbContext.Permission
            .Where(p => dto.PermissionIds.Contains(p.PermissionId))
            .ToListAsync();

        if (permissions.Count == 0)
        {
            throw new Exception("No valid permissions found");
        }

        // Xóa các permissions hiện tại (nếu cần cập nhật lại)
        role.RolePermissions.Clear();

        // Thêm các permissions mới
        foreach (var permission in permissions)
        {
            role.RolePermissions.Add(new RolePermission
            {
                RoleId = role.Id,
                PermissionId = permission.PermissionId
            });
        }

        await _dbContext.SaveChangesAsync();

        return "Permissions assigned successfully";
    }
}
