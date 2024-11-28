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

    [HttpGet]
    public async Task<IActionResult> GetAllPermissions()
    {
        var permissions = await _permissionService.GetAllPermissionsAsync();
        return Ok(permissions);
    }

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
            return BadRequest(ex.Message);
        }
    }
}
