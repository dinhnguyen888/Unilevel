using Microsoft.EntityFrameworkCore;
using Unilevel.Models;

public class AreaService
{
    private readonly AppDbContext _context;

    public AreaService(AppDbContext context)
    {
        _context = context;
    }


    // Lay het khu vuc
    public async Task<List<Area>> GetAllAreasAsync()
    {
        return await _context.Area.ToListAsync();
    }


    //Tim kiem 
    public async Task<Area?> SearchAreaByNameAsync(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return null;

        var trimmedSearchTerm = searchTerm.Trim().ToLower();

        return await _context.Area
            .FirstOrDefaultAsync(a => a.AreaName.ToLower().Trim().Contains(trimmedSearchTerm));
    }


    // Tao
    public async Task<Area> CreateAreaAsync(Area area)
    {
        try
        {
            _context.Area.Add(area);
            await _context.SaveChangesAsync();
            return area;
        }
        // catch khi row bi trung
        catch (DbUpdateException ex) when (ex.InnerException?.Message.Contains("duplicate") == true)
        {
            throw new Exception("Area already exists. Please provide unique data.");
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred: " + ex.Message);
        }
    }


    // Sua
    public async Task<bool> UpdateAreaAsync(string areaId, string newAreaName)
    {
        var area = await _context.Area.FindAsync(areaId); 
        if (area == null)
            return false;

        area.AreaName = newAreaName;

        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch (DbUpdateConcurrencyException)
        {
            throw;
        }
    }


    // Xoa
    public async Task<bool> DeleteAreaAsync(string id)
    {
        var area = await _context.Area.FindAsync(id);
        if (area == null)
            return false;

        _context.Area.Remove(area);
        await _context.SaveChangesAsync();
        return true;
    }


    //xem chi tiet khu vuc
    //xem tong nhan su trong khu vuc
    public async Task<List<User>> ViewInArea(string AreaId)
    {
        var area = await _context.Area.FindAsync(AreaId);
        if (area == null)
            return new List<User>();

        // Specify the GroupRoleIds you want to filter
        var targetGroupRoleIds = new[] { 2, 3 };

        // Query to get users in the specified AreaId with the matching GroupRoleIds
        var users = await _context.Users
            .Where(user => user.AreaId == AreaId) // Filter by AreaId
            .Where(user => _context.UserRoles
                .Where(userRole => _context.Roles
                    .Where(role => targetGroupRoleIds.Contains(role.GroupRoleId)) // Match GroupRoleId
                    .Select(role => role.Id)
                    .Contains(userRole.RoleId)) // Check if RoleId matches
                .Any(userRole => userRole.UserId == user.Id)) // Ensure the user has the role
            .ToListAsync();

        return users;
    }




}
