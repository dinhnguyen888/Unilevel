using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }
    //dang nhap 
    [HttpPost("register")]
    public async Task<IActionResult> Register(string username, string password, string email)
    {
        var result = await _authService.RegisterAsync(username, password, email);

        if (result.Succeeded)
        {
            return Ok(new { message = "Đăng ký thành công" });
        }

        return BadRequest(new { message = "Có lỗi xảy ra:", errors = result.Errors });
    }

    //dang ky
    [HttpPost("login")]
    public async Task<IActionResult> Login(string username, string password)
    {
        var result = await _authService.LoginAsync(username, password);

        if (result.Succeeded)
        {
            return Ok(new { message = "login ok" });
        }

        return Unauthorized(new { message = "Invalid login attempt" });
    }
    //dang xuat
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        await _authService.LogoutAsync();
        return Ok(new { message = "Logout ok" });
    }
    //gui yeu cau khoi phuc mat khau
    [HttpPost("forgot-password")]
    public async Task<IActionResult> ForgotPassword([FromBody] string email)
    {
        try
        {
            await _authService.SendPasswordResetTokenAsync(email);
            return Ok(new { message = "Password reset email sent." });
        }
        catch (ArgumentException)
        {
            return NotFound(new { message = "Email not found." });
        }
    }

    

    // Đặt lại mật khẩu
    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword(string email, string token, string newPassword)
    {
        var isReset = await _authService.ResetPasswordAsync(email, token, newPassword);
        return isReset ? Ok(new { message = "Password reset successful." }) : BadRequest(new { message = "Reset failed." });
    }



}
