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


    //doi mat khau
    [HttpPost("change-password")]
    public async Task<IActionResult> ChangePassword(string currentPassword, string newPassword)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized("User ID not found in token");
        }

        var result = await _personalInfoService.ChangePasswordAsync(userId, currentPassword, newPassword);

        if (result.Succeeded)
        {
            return Ok("Password changed successfully");
        }

        return BadRequest(result.Errors);
    }


    //lay thong tin ca nhan 
    [HttpGet("me")]
    public async Task<IActionResult> GetUserInfo()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized("User ID not found in token");
        }

        var user = await _personalInfoService.GetUserInfoAsync(userId);

        if (user == null)
        {
            return NotFound("User not found");
        }

        return Ok(user);
    }


    //sua thong tin ca nhan
    [HttpPut("update-info")]
    public async Task<IActionResult> UpdateUserInfo([FromBody] Profile request)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized("User ID not found in token");
        }

    
        var result = await _personalInfoService.UpdateUserInfoAsync(userId, request);

        if (result.Succeeded)
        {
            return Ok("User information updated successfully");
        }

        return BadRequest(result.Errors);
    }
}
