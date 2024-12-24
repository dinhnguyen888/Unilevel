using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Unilevel.Models;

public class RoleService
{
    private readonly AppDbContext _dbContext;
    private readonly RoleManager<Role> _roleManager;

    public RoleService(AppDbContext dbContext, RoleManager<Role> roleManager)
    {
        _dbContext = dbContext;
        _roleManager = roleManager;
    }

    // Create Role
    public async Task<string> CreateRoleAsync(CreateRoleDTO dto)
    {
        var groupRole = await _dbContext.GroupRole.FindAsync(dto.GroupRoleId);
        if (groupRole == null)
        {
            throw new Exception("GroupRole not found");
        }

        var role = new Role
        {
            Id = Guid.NewGuid().ToString(),
            Name = dto.Name,
            GroupRoleId = dto.GroupRoleId,
            GroupRole = groupRole
        };

        var result = await _roleManager.CreateAsync(role);
        if (!result.Succeeded)
        {
            throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
        }

        return "Role created successfully";
    }

    // Get Roles
    public async Task<List<RoleDTO>> GetRolesAsync()
    {
        return await _roleManager.Roles
            .Include(r => r.GroupRole)
            .Select(r => new RoleDTO
            {
                Id = r.Id,
                Name = r.Name,
                GroupRoleId = r.GroupRoleId,
                GroupRoleName = r.GroupRole.GroupRoleName
            }).ToListAsync();
    }

    // Update Role
    public async Task<string> UpdateRoleAsync(UpdateRoleDTO dto)
    {
        var role = await _roleManager.FindByIdAsync(dto.Id);
        if (role == null)
        {
            throw new Exception("Role not found");
        }

        var groupRole = await _dbContext.GroupRole.FindAsync(dto.GroupRoleId);
        if (groupRole == null)
        {
            throw new Exception("GroupRole not found");
        }

        role.Name = dto.Name;
        role.GroupRoleId = dto.GroupRoleId;
        role.GroupRole = groupRole;

        var result = await _roleManager.UpdateAsync(role);
        if (!result.Succeeded)
        {
            throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
        }

        return "Role updated successfully";
    }

    // Delete Role
    public async Task<string> DeleteRoleAsync(string id)
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            throw new Exception("Role not found");
        }

        var result = await _roleManager.DeleteAsync(role);
        if (!result.Succeeded)
        {
            throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
        }

        return "Role deleted successfully";
    }
}
