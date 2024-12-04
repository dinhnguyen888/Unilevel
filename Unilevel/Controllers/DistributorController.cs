using Microsoft.AspNetCore.Mvc;
using Unilevel.DTOs;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class DistributorsController : ControllerBase
{
    private readonly DistributorService _service;

    public DistributorsController(DistributorService service)
    {
        _service = service;
    }

    /// <summary>
    /// Tao moi mot nha phan phoi
    /// </summary>
    /// <param name="dto">Thong tin nha phan phoi</param>
    /// <returns>Nha phan phoi vua duoc tao</returns>
    [CustomAuthorize("Can Post Distributor", 1)]
    [HttpPost]
    public async Task<IActionResult> CreateDistributor([FromBody] DistributorDTO dto)
    {
        var distributor = await _service.CreateDistributorAsync(dto);
        return CreatedAtAction(nameof(GetDistributorById), new { id = distributor.Id }, distributor);
    }

    /// <summary>
    /// Cap nhat thong tin nha phan phoi
    /// </summary>
    /// <param name="id">Dinh danh nha phan phoi</param>
    /// <param name="dto">Thong tin cap nhat</param>
    /// <returns>Ket qua cap nhat</returns>
    [CustomAuthorize("Can Update Distributor", 1)]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateDistributor(string id, [FromBody] DistributorDTO dto)
    {
        var result = await _service.UpdateDistributorAsync(id, dto);
        return result ? NoContent() : NotFound("Khong tim thay nha phan phoi.");
    }

    /// <summary>
    /// Xoa mot nha phan phoi
    /// </summary>
    /// <param name="id">Dinh danh nha phan phoi can xoa</param>
    /// <returns>Ket qua xoa</returns>
    [CustomAuthorize("Can Delete Distributor", 1)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDistributor(string id)
    {
        var result = await _service.DeleteDistributorAsync(id);
        return result ? NoContent() : NotFound("Khong tim thay nha phan phoi.");
    }

    /// <summary>
    /// Lay danh sach tat ca cac nha phan phoi
    /// </summary>
    /// <returns>Danh sach nha phan phoi</returns>
    [GroupRoleAuthorize(1)]
    [HttpGet]
    public async Task<IActionResult> GetAllDistributors()
    {
        var distributors = await _service.GetAllDistributorsAsync();
        return Ok(distributors);
    }

    /// <summary>
    /// Lay thong tin nha phan phoi theo ID
    /// </summary>
    /// <param name="id">Dinh danh nha phan phoi</param>
    /// <returns>Thong tin nha phan phoi</returns>
    [GroupRoleAuthorize(1)]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetDistributorById(string id)
    {
        var distributor = await _service.GetDistributorByIdAsync(id);
        return distributor == null ? NotFound("Khong tim thay nha phan phoi.") : Ok(distributor);
    }
}