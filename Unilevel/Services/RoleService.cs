using Microsoft.EntityFrameworkCore;
using Unilevel.Models;

public class RoleService
{
    private readonly AppDbContext _dbContext;

    public RoleService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }



    // Tao
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

        await _dbContext.Roles.AddAsync(role);
        await _dbContext.SaveChangesAsync();

        return "Role created successfully";
    }


    // Doc
    public async Task<List<RoleDTO>> GetRolesAsync()
    {
        return await _dbContext.Roles
            .Include(r => r.GroupRole)
            .Select(r => new RoleDTO
            {
                Id = r.Id,
                Name = r.Name,
                GroupRoleId = r.GroupRoleId
            }).ToListAsync();
    }

    // Sua
    public async Task<string> UpdateRoleAsync(UpdateRoleDTO dto)
    {
        var role = await _dbContext.Roles.FindAsync(dto.Id);
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

        await _dbContext.SaveChangesAsync();

        return "Role updated successfully";
    }

    // Xoa
    public async Task<string> DeleteRoleAsync(string id)
    {
        var role = await _dbContext.Roles.FindAsync(id);
        if (role == null)
        {
            throw new Exception("Role not found");
        }

        _dbContext.Roles.Remove(role);
        await _dbContext.SaveChangesAsync();

        return "Role deleted successfully";
    }
}
