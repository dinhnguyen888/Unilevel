using Microsoft.AspNetCore.Authorization;
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
    [HttpPost("login")]
    public async Task<IActionResult> Login(string username, string password)
    {
        var (success, token) = await _authService.LoginAsync(username, password);

        if (success)
        {
            return Ok(new { message = "Login successful", token = token });
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
    //flow: quen mat khau -> nhap tai khoan gmail -> nhan token qua gmail (do khong cho phep lam UI )
    //-> nhap token vao reset mat khau 
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



    // Reset password
    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword(string email, string token)
    {
        var isReset = await _authService.ResetPasswordAsync(email, token);
        return isReset ? Ok(new { message = "Password reset successful." }) : BadRequest(new { message = "Reset failed." });
    }



}
