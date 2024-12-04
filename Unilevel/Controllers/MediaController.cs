using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class MediaController : ControllerBase
{
    private readonly MediaService _mediaService;

    public MediaController(MediaService mediaService)
    {
        _mediaService = mediaService;
    }

    /// <summary>
    /// Lay danh sach tat ca cac file hinh anh va video
    /// </summary>
    /// <param name="searchQuery">Tu khoa tim kiem tuy chon de loc cac file</param>
    /// <returns>Danh sach cac file hinh anh va video</returns>
    /// <response code="200">Tra ve danh sach cac file thanh cong</response>
    [HttpGet]
    public async Task<IActionResult> GetAllMedia([FromQuery] string? searchQuery)
    {
        var media = await _mediaService.GetAllMediaAsync(searchQuery);
        return Ok(media);
    }

    /// <summary>
    /// Them moi mot file hinh anh va video
    /// </summary>
    /// <param name="file">Tap tin file can tai len</param>
    /// <param name="title">Tieu de cua file</param>
    /// <returns>file hinh anh va video moi duoc tao</returns>
    /// <response code="201">Tao moi file thanh cong</response>
    /// <response code="400">Loi khi tai len hoac xu ly file</response>
    [CustomAuthorize("Can Post Media", 1)]
    [HttpPost]
    public async Task<IActionResult> AddMedia(IFormFile file, string title)
    {
        try
        {
            var media = await _mediaService.AddMediaAsync(file, title);
            return CreatedAtAction(nameof(GetAllMedia), new { id = media.MediaLink }, media);
        }
        catch (ArgumentException ex)
        {
            return BadRequest("Khong the tai len hoac xu ly file.");
        }
    }

    /// <summary>
    /// Xoa mot file hinh anh va video theo ma dinh danh
    /// </summary>
    /// <param name="id">Ma dinh danh cua file can xoa</param>
    /// <returns>Ket qua thao tac xoa file</returns>
    /// <response code="204">Xoa file thanh cong</response>
    /// <response code="404">Khong tim thay file voi ma dinh danh da cho</response>
    [CustomAuthorize("Can Delete Media", 1)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMedia(int id)
    {
        var result = await _mediaService.DeleteMediaAsync(id);
        if (!result)
        {
            return NotFound($"Khong tim thay file voi ma {id}.");
        }
        return NoContent();
    }
}