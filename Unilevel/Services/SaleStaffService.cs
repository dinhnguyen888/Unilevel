using Microsoft.EntityFrameworkCore;
using Unilevel.DTOs;
using Unilevel.Models;

public class SaleStaffService
{
    private readonly AppDbContext _context;

    public SaleStaffService(AppDbContext context)
    {
        _context = context;
    }

    // Tạo SaleStaff mới
    public async Task<SaleStaff> CreateSaleStaffAsync(SaleStaffDTO dto)
    {
        var saleStaff = new SaleStaff
        {
            Id = Guid.NewGuid().ToString(),
            UserName = dto.Email,
            Email = dto.Email,
            AreaId = dto.AreaId,
            SuperiorId = dto.SuperiorId,
            IsActive = dto.IsActive,
            JoinDate = DateTime.UtcNow,
        };

        await _context.Users.AddAsync(saleStaff);
        await _context.SaveChangesAsync();
        return saleStaff;
    }

    // Cập nhật thông tin SaleStaff
    public async Task<bool> UpdateSaleStaffAsync(string id, SaleStaffDTO dto)
    {
        var saleStaff = await _context.SaleStaff.FindAsync(id);
        if (saleStaff == null) return false;

        saleStaff.UserName = dto.FullName;
        saleStaff.Email = dto.Email;
        saleStaff.AreaId = dto.AreaId;
        saleStaff.SuperiorId = dto.SuperiorId;
        saleStaff.IsActive = dto.IsActive;

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

    // Xóa SaleStaff
    public async Task<bool> DeleteSaleStaffAsync(string id)
    {
        var saleStaff = await _context.SaleStaff.FindAsync(id);
        if (saleStaff == null) return false;

        _context.SaleStaff.Remove(saleStaff);
        await _context.SaveChangesAsync();
        return true;
    }

    // Lấy danh sách SaleStaff
    public async Task<List<SaleStaff>> GetAllSaleStaffAsync()
    {
        return await _context.SaleStaff.Include(s => s.Superior).ToListAsync();
    }
}
