using Microsoft.EntityFrameworkCore;
using Unilevel.Models;

public class PermissionService
{
    private readonly AppDbContext _dbContext;

    public PermissionService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // Doc
    public async Task<List<PermissionDTO>> GetAllPermissionsAsync()
    {
        return await _dbContext.Permission
            .Select(p => new PermissionDTO
            {
                PermissionId = p.PermissionId,
                PermissionName = p.PermissionName
            }).ToListAsync();
    }


    // Gan Permission cho Role
    public async Task<string> AssignPermissionsToRoleAsync(AssignPermissionDTO dto)
    {
        var role = await _dbContext.Roles
            .Include(r => r.RolePermissions)
            .FirstOrDefaultAsync(r => r.Id == dto.RoleId);

        if (role == null)
        {
            throw new Exception("Role khong hop le");
        }

        var permissions = await _dbContext.Permission
            .Where(p => dto.PermissionIds.Contains(p.PermissionId))
            .ToListAsync();

        if (permissions.Count == 0)
        {
            throw new Exception("Role khong tim thay");
        }

        role.RolePermissions.Clear();

        // Them permission moi
        foreach (var permission in permissions)
        {
            role.RolePermissions.Add(new RolePermission
            {
                RoleId = role.Id,
                PermissionId = permission.PermissionId
            });
        }

        await _dbContext.SaveChangesAsync();

        return "Role duoc gan thanh cong";
    }
}
