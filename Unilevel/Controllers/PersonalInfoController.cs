using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Unilevel.DTOs;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class PersonalInfoController : ControllerBase
{
    private readonly PersonalInfoService _personalInfoService;

    public PersonalInfoController(PersonalInfoService personalInfoService)
    {
        _personalInfoService = personalInfoService;
    }

    /// <summary>
    /// Thay doi mat khau nguoi dung
    /// </summary>
    /// <param name="currentPassword">Mat khau hien tai</param>
    /// <param name="newPassword">Mat khau moi</param>
    /// <returns>Ket qua thay doi mat khau</returns>
    /// <response code="200">Thay doi mat khau thanh cong</response>
    /// <response code="400">Loi khi thay doi mat khau</response>
    /// <response code="401">Khong tim thay ma nguoi dung</response>
    [HttpPost("change-password")]
    public async Task<IActionResult> ChangePassword(string currentPassword, string newPassword)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized("Khong tim thay ma nguoi dung trong token");
        }
        var result = await _personalInfoService.ChangePasswordAsync(userId, currentPassword, newPassword);
        if (result.Succeeded)
        {
            return Ok("Mat khau da duoc thay doi thanh cong");
        }
        return BadRequest(result.Errors);
    }

    /// <summary>
    /// Lay thong tin ca nhan cua nguoi dung
    /// </summary>
    /// <returns>Thong tin ca nhan</returns>
    /// <response code="200">Lay thong tin thanh cong</response>
    /// <response code="401">Khong tim thay ma nguoi dung</response>
    /// <response code="404">Khong tim thay nguoi dung</response>
    [HttpGet("me")]
    public async Task<IActionResult> GetUserInfo()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized("Khong tim thay ma nguoi dung trong token");
        }
        var user = await _personalInfoService.GetUserInfoAsync(userId);
        if (user == null)
        {
            return NotFound("Khong tim thay nguoi dung");
        }
        return Ok(user);
    }

    /// <summary>
    /// Cap nhat thong tin ca nhan nguoi dung
    /// </summary>
    /// <param name="request">Thong tin ca nhan moi</param>
    /// <returns>Ket qua cap nhat thong tin</returns>
    /// <response code="200">Cap nhat thong tin thanh cong</response>
    /// <response code="400">Loi khi cap nhat thong tin</response>
    /// <response code="401">Khong tim thay ma nguoi dung</response>
    [HttpPut("update-info")]
    public async Task<IActionResult> UpdateUserInfo([FromBody] Profile request)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized("Khong tim thay ma nguoi dung trong token");
        }

        var result = await _personalInfoService.UpdateUserInfoAsync(userId, request);
        if (result.Succeeded)
        {
            return Ok("Thong tin nguoi dung da duoc cap nhat thanh cong");
        }
        return BadRequest(result.Errors);
    }
}