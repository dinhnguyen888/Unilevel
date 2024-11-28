using Microsoft.EntityFrameworkCore;
using Unilevel.Models;

public class AreaService
{
    private readonly AppDbContext _context;

    public AreaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Area>> GetAllAreasAsync()
    {
        return await _context.Area.ToListAsync();
    }

    public async Task<Area?> SearchAreaByNameAsync(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return null;

        var trimmedSearchTerm = searchTerm.Trim().ToLower();

        return await _context.Area
            .FirstOrDefaultAsync(a => a.AreaName.ToLower().Trim().Contains(trimmedSearchTerm));
    }



    public async Task<Area> CreateAreaAsync(Area area)
    {
       
        _context.Area.Add(area);
        await _context.SaveChangesAsync();
        return area;
    }

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
    public async Task<List<User>> ViewInArea( string AreaId)
    {
        var area = await _context.Area.FindAsync(AreaId);
        if (area == null)
            return new List<User>();
        var saleStaff = await _context.Users
         .Where(x => x.AreaId == AreaId)
         .ToListAsync();

        return saleStaff;
    }
}
