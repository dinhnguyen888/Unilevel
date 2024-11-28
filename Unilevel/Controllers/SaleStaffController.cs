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

    [HttpPost]
    public async Task<IActionResult> CreateSaleStaff(SaleStaffDTO dto)
    {
        var result = await _service.CreateSaleStaffAsync(dto);
        return CreatedAtAction(nameof(GetSaleStaffById), new { id = result.Id }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSaleStaff(string id, SaleStaffDTO dto)
    {
        var success = await _service.UpdateSaleStaffAsync(id, dto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSaleStaff(string id)
    {
        var success = await _service.DeleteSaleStaffAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllSaleStaff()
    {
        var result = await _service.GetAllSaleStaffAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSaleStaffById(string id)
    {
        var result = await _service.GetAllSaleStaffAsync();
        return Ok(result.FirstOrDefault(s => s.Id == id));
    }
}
