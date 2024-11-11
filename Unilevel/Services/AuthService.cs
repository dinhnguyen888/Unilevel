using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

public class AuthService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly EmailService _emailService;
    public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, EmailService emailService)
{
    _userManager = userManager;
    _signInManager = signInManager;
    _emailService = emailService; // Initialize EmailService
}

    public async Task<IdentityResult> RegisterAsync(string username, string password, string email)
    {
        var user = new IdentityUser
        {
            UserName = username,
            Email = email
        };

        var result = await _userManager.CreateAsync(user, password);
        return result;
    }

    public async Task<SignInResult> LoginAsync(string username, string password)
    {
        return await _signInManager.PasswordSignInAsync(username, password, isPersistent: false, lockoutOnFailure: false);
    }

    public async Task LogoutAsync()
    {
        await _signInManager.SignOutAsync();
    }

    public async Task SendPasswordResetTokenAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            throw new ArgumentException("User not found.");
        }

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);

        var subject = "Password Reset Request";
        var body = $"Please reset your password by using token: {token}";

        await _emailService.SendEmailAsync(email, subject, body);
    }

    

    public async Task<bool> ResetPasswordAsync(string email, string token, string newPassword)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null) return false;

        var result = await _userManager.ResetPasswordAsync(user, token, newPassword);
        return result.Succeeded;
    }
}
