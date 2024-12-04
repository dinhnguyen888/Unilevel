using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class RolesController : ControllerBase
{
    private readonly RoleService _roleService;

    public RolesController(RoleService roleService)
    {
        _roleService = roleService;
    }

    /// <summary>
    /// Tao moi vai tro
    /// </summary>
    /// <param name="dto">Thong tin vai tro can tao</param>
    /// <returns>Ket qua tao vai tro</returns>
    /// <response code="200">Tao vai tro thanh cong</response>
    /// <response code="400">Loi khi tao vai tro</response>
    [GroupRoleAuthorize(1)]
    [HttpPost]
    public async Task<IActionResult> CreateRole(CreateRoleDTO dto)
    {
        try
        {
            var result = await _roleService.CreateRoleAsync(dto);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest("Khong the tao vai tro moi.");
        }
    }

    /// <summary>
    /// Lay danh sach tat ca cac vai tro
    /// </summary>
    /// <returns>Danh sach cac vai tro</returns>
    /// <response code="200">Lay danh sach vai tro thanh cong</response>
    [HttpGet]
    public async Task<IActionResult> GetRoles()
    {
        var roles = await _roleService.GetRolesAsync();
        return Ok(roles);
    }

    /// <summary>
    /// Cap nhat thong tin vai tro
    /// </summary>
    /// <param name="dto">Thong tin vai tro can cap nhat</param>
    /// <returns>Ket qua cap nhat vai tro</returns>
    /// <response code="200">Cap nhat vai tro thanh cong</response>
    /// <response code="400">Loi khi cap nhat vai tro</response>
    [GroupRoleAuthorize(1)]
    [HttpPut]
    public async Task<IActionResult> UpdateRole(UpdateRoleDTO dto)
    {
        try
        {
            var result = await _roleService.UpdateRoleAsync(dto);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest("Khong the cap nhat vai tro.");
        }
    }

    /// <summary>
    /// Xoa vai tro theo ma dinh danh
    /// </summary>
    /// <param name="id">Ma dinh danh cua vai tro can xoa</param>
    /// <returns>Ket qua xoa vai tro</returns>
    /// <response code="200">Xoa vai tro thanh cong</response>
    /// <response code="400">Loi khi xoa vai tro</response>
    [GroupRoleAuthorize(1)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRole(string id)
    {
        try
        {
            var result = await _roleService.DeleteRoleAsync(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest("Khong the xoa vai tro.");
        }
    }
}