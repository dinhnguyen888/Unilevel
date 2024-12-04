using Humanizer.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Unilevel.Models;


public class AuthService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly EmailService _emailService;
    private readonly IConfiguration _configuration;
    private readonly AppDbContext _appDbContext;

    public AuthService(UserManager<User> userManager, SignInManager<User> signInManager, EmailService emailService, IConfiguration configuration, AppDbContext appDbContext)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _emailService = emailService;
        _configuration = configuration;
        _appDbContext = appDbContext;
    }


    //dang ky user moi (testing)
    public async Task<IdentityResult> RegisterAsync(string username, string password, string email)
    {
        var user = new User 
        {
            UserName = username,
            Email = email
        };

        var result = await _userManager.CreateAsync(user, password);
        return result;
    }


    //dang nhap user, tra ve jwt token
    public async Task<(bool, string)> LoginAsync(string username, string password)
    {
        var result = await _signInManager.PasswordSignInAsync(username, password, isPersistent: false, lockoutOnFailure: false);
        if (result.Succeeded)
        {
            var user = await _userManager.FindByNameAsync(username);
            var token = await GenerateJwtTokenAsync(user);
            return (true, token);
        }

        return (false, "Invalid username or password");
    }


    //tao token moi sau khi dung tai khoan, mat khau trong qua trinh dang nhap
    private async Task<string> GenerateJwtTokenAsync(User user)
    {
        var roles = await _userManager.GetRolesAsync(user);
        var groupRoleId = await _appDbContext.Roles
            .Where(r => roles.Contains(r.Name))
            .Select(r => r.GroupRole.GroupRoleId)
            .Distinct()
            .ToListAsync();
        var rolesPermissions = await _appDbContext.RolePermissions
            .Where(up => roles.Contains(up.Role.Name))
            .Select(up => up.Permission.PermissionName) 
            .Distinct()
            .ToListAsync();

        var areaId = await _appDbContext.Users
            .Where(u => u.Id == user.Id) 
            .Select(u => u.AreaId)     
            .FirstOrDefaultAsync();


        if (groupRoleId == null || !groupRoleId.Any())
        {
            return null;  
        }
        

        var jwtSettings = _configuration.GetSection("Jwt");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };
        claims.Add(new Claim("AreaId", user.AreaId ?? "System"));
        claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));
        claims.AddRange(groupRoleId.Select(gr => new Claim("GroupRole", gr.ToString())));
        claims.AddRange(rolesPermissions.Select(permission => new Claim("Permission", permission)));

        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"],
            audience: jwtSettings["Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(int.Parse(jwtSettings["ExpiresInMinutes"])),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }


    //dang xuat
    public async Task LogoutAsync()
    {
        await _signInManager.SignOutAsync();
    }


    //gui yeu cau reset mat khau (su dung sendgrid de gui qua email)
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
    

    //lay token o email truyen vao tham so de reset mat khau (mat khau mac dinh la abc123@ )
    public async Task<bool> ResetPasswordAsync(string email, string token)
    {
        var passwordSetting = _configuration.GetSection("PasswordDefault");
        string newPassword = passwordSetting["Pass"];

        var user = await _userManager.FindByEmailAsync(email);
        if (user == null) return false;

        var result = await _userManager.ResetPasswordAsync(user, token, newPassword);
        return result.Succeeded;
    }

}
