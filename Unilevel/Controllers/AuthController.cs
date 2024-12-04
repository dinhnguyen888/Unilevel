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

    /// <summary>
    /// Dang nhap he thong
    /// </summary>
    /// <param name="username">Ten dang nhap</param>
    /// <param name="password">Mat khau</param>
    /// <returns>Token xac thuc neu dang nhap thanh cong, hoac loi neu that bai</returns>
    [HttpPost("login")]
    public async Task<IActionResult> Login(string username, string password)
    {
        var (success, token) = await _authService.LoginAsync(username, password);
        if (success)
        {
            return Ok(new { message = "Dang nhap thanh cong", token = token });
        }
        return Unauthorized(new { message = "Dang nhap khong thanh cong" });
    }

    /// <summary>
    /// Dang xuat khoi he thong
    /// </summary>
    /// <returns>Ket qua dang xuat</returns>
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        await _authService.LogoutAsync();
        return Ok(new { message = "Dang xuat thanh cong" });
    }

    /// <summary>
    /// Gui yeu cau khoi phuc mat khau
    /// Quy trinh: quen mat khau -> nhap tai khoan gmail -> nhan token qua gmail -> nhap token de reset mat khau
    /// </summary>
    /// <param name="email">Dia chi email dang ky</param>
    /// <returns>Ket qua gui email khoi phuc mat khau</returns>
    [HttpPost("forgot-password")]
    public async Task<IActionResult> ForgotPassword([FromBody] string email)
    {
        try
        {
            await _authService.SendPasswordResetTokenAsync(email);
            return Ok(new { message = "Email khoi phuc mat khau da duoc gui." });
        }
        catch (ArgumentException)
        {
            return NotFound(new { message = "Khong tim thay email." });
        }
    }

    /// <summary>
    /// Dat lai mat khau moi
    /// </summary>
    /// <param name="email">Dia chi email</param>
    /// <param name="token">Token khoi phuc mat khau</param>
    /// <returns>Ket qua dat lai mat khau</returns>
    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword(string email, string token)
    {
        var isReset = await _authService.ResetPasswordAsync(email, token);
        return isReset
            ? Ok(new { message = "Dat lai mat khau thanh cong." })
            : BadRequest(new { message = "Dat lai mat khau that bai." });
    }
}