using Microsoft.AspNetCore.Mvc;
using Unilevel.Models;
/// <summary>
/// Cac chuc nang lien quan den quan ly vung khu vuc
/// </summary>
[ApiController]
[Route("api/for-owner/[controller]")]
public class AreaController : ControllerBase
{
    private readonly AreaService _areaService;

    public AreaController(AreaService areaService)
    {
        _areaService = areaService;
    }

    /// <summary>
    /// Them moi khu vuc.
    /// </summary>
    /// <param name="area">Thong tin khu vuc.</param>
    /// <returns>Tra ve khu vuc da duoc tao.</returns>
    [GroupRoleAuthorize(1)]
    [HttpPost]
    public async Task<IActionResult> CreateArea([FromBody] Area area)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdArea = await _areaService.CreateAreaAsync(area);
        return CreatedAtAction(nameof(CreateArea), new { id = createdArea.AreaId }, createdArea);
    }

    /// <summary>
    /// Lay danh sach tat ca cac khu vuc.
    /// </summary>
    /// <returns>Danh sach cac khu vuc.</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllAreas()
    {
        var areas = await _areaService.GetAllAreasAsync();
        return Ok(areas);
    }

    /// <summary>
    /// Tim kiem khu vuc theo ten.
    /// </summary>
    /// <param name="name">Ten khu vuc can tim.</param>
    /// <returns>Tra ve thong tin khu vuc tim thay.</returns>
    [GroupRoleAuthorize(1)]
    [HttpGet("search/{name}")]
    public async Task<IActionResult> SearchAreaByName(string name)
    {
        var area = await _areaService.SearchAreaByNameAsync(name);
        if (area == null)
            return NotFound(new { message = "Area not found" });

        return Ok(area);
    }

    /// <summary>
    /// Cap nhat thong tin khu vuc.
    /// </summary>
    /// <param name="id">Id cua khu vuc.</param>
    /// <param name="area">Thong tin khu vuc moi.</param>
    /// <returns>Trang thai cap nhat.</returns>
    [GroupRoleAuthorize(1)]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateArea(string id, [FromBody] Area area)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var isUpdated = await _areaService.UpdateAreaAsync(id, area.AreaName);
        if (!isUpdated)
            return NotFound();

        return NoContent();
    }

    /// <summary>
    /// Xoa khu vuc theo id.
    /// </summary>
    /// <param name="id">Id cua khu vuc.</param>
    /// <returns>Trang thai xoa.</returns>
    [GroupRoleAuthorize(1)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteArea(string id)
    {
        var isDeleted = await _areaService.DeleteAreaAsync(id);
        if (!isDeleted)
            return NotFound();

        return NoContent();
    }

    /// <summary>
    /// Xem danh sach nguoi dung trong khu vuc.
    /// </summary>
    /// <param name="areaId">Id cua khu vuc.</param>
    /// <returns>Danh sach nguoi dung trong khu vuc.</returns>
    [GroupRoleAuthorize(1)]
    [HttpGet("viewinarea/{areaId}")]
    public async Task<ActionResult<List<User>>> ViewInArea(string areaId)
    {
        try
        {
            var usersInArea = await _areaService.ViewInArea(areaId);
            if (usersInArea == null || usersInArea.Count == 0)
            {
                return NotFound("No users found in this area with 'sale' or 'distributor' role.");
            }

            return Ok(usersInArea);
        }
        catch (Exception ex)
        {
            return BadRequest($"Error retrieving users: {ex.Message}");
        }
    }
}
