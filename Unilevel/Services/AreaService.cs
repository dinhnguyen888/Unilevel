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

        // Lay danh sach Sale va Distributor
        var saleAndDistributorRoleNames = new[] { "Sale", "Distributor" };

        // Truy van
        var saleStaff = await _context.Users
            .Where(x => x.AreaId == AreaId)
            .Where(x => _context.UserRoles
                .Where(ur => saleAndDistributorRoleNames.Contains(_context.Roles
                    .Where(r => r.Id == ur.RoleId)
                    .Select(r => r.Name)
                    .FirstOrDefault()))
                .Any(ur => ur.UserId == x.Id)) // Kiem tra nguoi dung co vai tro phu hop
            .ToListAsync();

        return saleStaff;
    }



}
