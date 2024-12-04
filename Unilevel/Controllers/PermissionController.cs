using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PermissionsController : ControllerBase
{
    private readonly PermissionService _permissionService;

    public PermissionsController(PermissionService permissionService)
    {
        _permissionService = permissionService;
    }

    /// <summary>
    /// Lay danh sach tat ca cac quyen
    /// </summary>
    /// <returns>Danh sach cac quyen</returns>
    /// <response code="200">Lay danh sach quyen thanh cong</response>
    [GroupRoleAuthorize(1)]
    [HttpGet]
    public async Task<IActionResult> GetAllPermissions()
    {
        var permissions = await _permissionService.GetAllPermissionsAsync();
        return Ok(permissions);
    }

    /// <summary>
    /// Gan quyen cho mot vai tro
    /// </summary>
    /// <param name="dto">Thong tin phan quyen cho vai tro</param>
    /// <returns>Ket qua gan quyen</returns>
    /// <response code="200">Gan quyen cho vai tro thanh cong</response>
    /// <response code="400">Loi khi gan quyen cho vai tro</response>
    [GroupRoleAuthorize(1)]
    [HttpPost("assign-for-role")]
    public async Task<IActionResult> AssignPermissionsToRole(AssignPermissionDTO dto)
    {
        try
        {
            var result = await _permissionService.AssignPermissionsToRoleAsync(dto);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest("Khong the gan quyen cho vai tro.");
        }
    }
}