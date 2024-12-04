using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Unilevel.Models;
using System.Security.Claims;

public class CustomAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
{
    public readonly string _requiredPermission;
    private readonly int _requiredGroupRoleId;

    // Constructor nhận cả quyền và group role
    public CustomAuthorizeAttribute(string requiredPermission, int requiredGroupRoleId)
    {
        _requiredPermission = requiredPermission;
        _requiredGroupRoleId = requiredGroupRoleId;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = context.HttpContext.User;

        if (user.Identity == null || !user.Identity.IsAuthenticated)
        {
            context.Result = new Microsoft.AspNetCore.Mvc.ForbidResult();
            return;
        }

        // Lấy các permission từ claims trong JWT
        var userPermissions = user.Claims
            .Where(c => c.Type == "Permission")
            .Select(c => c.Value)
            .ToList();

        // Kiểm tra quyền (Permission) có trong claims
        bool hasPermission = userPermissions.Contains(_requiredPermission);

        // Lấy GroupRole từ claims
        var dbContext = context.HttpContext.RequestServices.GetService<AppDbContext>();
        var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

        // Kiểm tra GroupRole của người dùng từ database
        var userGroupRoleId = dbContext.Users
            .Where(u => u.Id == userId)
            .Join(
                dbContext.UserRoles,
                u => u.Id,
                ur => ur.UserId,
                (u, ur) => new { ur.RoleId })
            .Join(
                dbContext.Roles,
                ur => ur.RoleId,
                r => r.Id,
                (ur, r) => r.GroupRoleId)
            .FirstOrDefault();

        // Kiểm tra nếu người dùng có quyền hoặc thuộc group role hợp lệ
        if (!hasPermission && userGroupRoleId != _requiredGroupRoleId)
        {
            context.Result = new Microsoft.AspNetCore.Mvc.ForbidResult();
        }
    }
}
