using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

public class TokenMiddleware
{
    private readonly RequestDelegate _next;

    public TokenMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        if (token != null)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = jwtTokenHandler.ReadToken(token) as JwtSecurityToken;

            if (jwtToken != null && jwtToken.ValidTo > DateTime.UtcNow)
            {
                // Nếu token hợp lệ và chưa hết hạn, tiếp tục xử lý request
                context.User = new ClaimsPrincipal(new ClaimsIdentity(jwtToken.Claims, "jwt"));
            }
        }

        await _next(context);
    }
}
