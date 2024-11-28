using Microsoft.AspNetCore.Mvc;
using Unilevel.Models;

[ApiController]
[Route("api/for-owner/[controller]")]
public class AreaController : ControllerBase
{
    private readonly AreaService _areaService;

    public AreaController(AreaService areaService) 
    {
        _areaService = areaService;
    }


    // Them
    [HttpPost]
    public async Task<IActionResult> CreateArea([FromBody] Area area)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdArea = await _areaService.CreateAreaAsync(area);
        return CreatedAtAction(nameof(CreateArea), new { id = createdArea.AreaId }, createdArea);
    }


    // Doc
    [HttpGet]
    public async Task<IActionResult> GetAllAreas()
    {
        var areas = await _areaService.GetAllAreasAsync();
        return Ok(areas);
    }


    // Tim kiem theo ten khu vuc
    [HttpGet("search/{name}")]
    public async Task<IActionResult> SearchAreaByName(string name)
    {
        var area = await _areaService.SearchAreaByNameAsync(name);
        if (area == null)
            return NotFound(new { message = "Area not found" });

        return Ok(area);
    }


    // Sua
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateArea(string id, [FromBody] Area area)
    {
      

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var isUpdated = await _areaService.UpdateAreaAsync(id , area.AreaName);
        if (!isUpdated)
            return NotFound();

        return NoContent();
    }


    // Xoa
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteArea(string id)
    {
        var isDeleted = await _areaService.DeleteAreaAsync(id);
        if (!isDeleted)
            return NotFound();

        return NoContent();
    }
}
