using Microsoft.AspNetCore.Mvc;
using Unilevel.DTOs;
using Unilevel.Models;

[Route("api/[controller]")]
[ApiController]
public class SaleStaffController : ControllerBase
{
    private readonly SaleStaffService _service;

    public SaleStaffController(SaleStaffService service)
    {
        _service = service;
    }

    /// <summary>
    /// Tao moi nhan vien kinh doanh
    /// </summary>
    /// <param name="dto">Thong tin nhan vien kinh doanh</param>
    /// <returns>Nhan vien kinh doanh vua duoc tao</returns>
    /// <response code="201">Tao nhan vien kinh doanh thanh cong</response>
    [CustomAuthorize("Can Post SaleStaff", 1)]
    [HttpPost]
    public async Task<IActionResult> CreateSaleStaff(SaleStaffDTO dto)
    {
        var result = await _service.CreateSaleStaffAsync(dto);
        return StatusCode(201, result);
    }

    /// <summary>
    /// Cap nhat thong tin nhan vien kinh doanh
    /// </summary>
    /// <param name="id">Ma dinh danh nhan vien kinh doanh</param>
    /// <param name="dto">Thong tin cap nhat</param>
    /// <returns>Ket qua cap nhat</returns>
    /// <response code="204">Cap nhat thanh cong</response>
    /// <response code="404">Khong tim thay nhan vien kinh doanh</response>
    [CustomAuthorize("Can Update SaleStaff", 1)]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSaleStaff(string id, SaleStaffDTO dto)
    {
        var success = await _service.UpdateSaleStaffAsync(id, dto);
        if (!success) return NotFound("Khong tim thay nhan vien kinh doanh.");
        return NoContent();
    }

    /// <summary>
    /// Xoa nhan vien kinh doanh
    /// </summary>
    /// <param name="id">Ma dinh danh nhan vien kinh doanh</param>
    /// <returns>Ket qua xoa</returns>
    /// <response code="204">Xoa thanh cong</response>
    /// <response code="404">Khong tim thay nhan vien kinh doanh</response>
    [CustomAuthorize("Can Delete SaleStaff", 1)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSaleStaff(string id)
    {
        var success = await _service.DeleteSaleStaffAsync(id);
        if (!success) return NotFound("Khong tim thay nhan vien kinh doanh.");
        return NoContent();
    }

    /// <summary>
    /// Lay danh sach tat ca nhan vien kinh doanh
    /// </summary>
    /// <returns>Danh sach nhan vien kinh doanh</returns>
    /// <response code="200">Lay danh sach thanh cong</response>
    [HttpGet]
    public async Task<IActionResult> GetAllSaleStaff()
    {
        var result = await _service.GetAllSaleStaffAsync();
        return Ok(result);
    }

    /// <summary>
    /// Lay thong tin nhan vien kinh doanh theo ma dinh danh
    /// </summary>
    /// <param name="id">Ma dinh danh nhan vien kinh doanh</param>
    /// <returns>Thong tin nhan vien kinh doanh</returns>
    /// <response code="200">Lay thong tin thanh cong</response>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetSaleStaffById(string id)
    {
        var result = await _service.GetAllSaleStaffAsync();
        return Ok(result.FirstOrDefault(s => s.Id == id));
    }
}