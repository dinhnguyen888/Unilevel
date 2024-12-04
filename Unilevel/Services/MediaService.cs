using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Unilevel.DTOs;
using Unilevel.Models;

public class MediaService
{
    private readonly AppDbContext _context;

    public MediaService(AppDbContext context)
    {
        _context = context;
    }


    // Doc
    public async Task<List<MediaDTO>> GetAllMediaAsync(string searchQuery)
    {
        var query = _context.Set<Media>().AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(m => EF.Functions.Like(m.MediaTitle, $"%{searchQuery}%"));
        }

        return await query
            .Select(m => new MediaDTO
            {
                MediaLink = m.MediaLink,
                MediaTitle = m.MediaTitle,
                ImportTime = m.ImportTime
            })
            .ToListAsync();
    }


    // Them
    public async Task<MediaDTO> AddMediaAsync(IFormFile file, string title)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("File khong hop le.");

        var uploadsFolder = Path.Combine("wwwroot", "uploads", "media");
        if (!Directory.Exists(uploadsFolder))
        {
            Directory.CreateDirectory(uploadsFolder);
        }

        var fileExtension = Path.GetExtension(file.FileName);
        var sanitizedFileName = Path.GetFileNameWithoutExtension(file.FileName).Replace(" ", "_");
        var fileName = $"{Guid.NewGuid()}_{sanitizedFileName}{fileExtension}";
        var filePath = Path.Combine(uploadsFolder, fileName);

        try
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }
        catch (Exception ex)
        {
            throw new IOException($"Loi khi up file: {ex.Message}", ex);
        }

        var media = new Media
        {
            MediaLink = $"/uploads/media/{fileName}",
            MediaTitle = title,
            ImportTime = DateTime.UtcNow
        };

        _context.Set<Media>().Add(media);
        await _context.SaveChangesAsync();

        return new MediaDTO
        {
            MediaLink = media.MediaLink,
            MediaTitle = media.MediaTitle,
            ImportTime = media.ImportTime
        };
    }


    // Xoa
    public async Task<bool> DeleteMediaAsync(int id)
    {
        var media = await _context.Set<Media>().FindAsync(id);
        if (media == null) return false;

        var filePath = Path.Combine("wwwroot", media.MediaLink.TrimStart('/'));
        try
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        catch (Exception ex)
        {
            // Log loi
            Console.WriteLine($"Xoa file that bai: {ex.Message}");
        }

        _context.Set<Media>().Remove(media);
        await _context.SaveChangesAsync();

        return true;
    }
}
