using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using Unilevel.Models;

public class GroupRoleAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
{
    private readonly int _requiredGroupRoleId;

    public GroupRoleAuthorizeAttribute(int requiredGroupRoleId)
    {
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

        var dbContext = context.HttpContext.RequestServices.GetService<AppDbContext>();
        var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

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

        if (userGroupRoleId != _requiredGroupRoleId)
        {
            context.Result = new Microsoft.AspNetCore.Mvc.ForbidResult();
        }
    }
}
