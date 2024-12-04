using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Linq;
using Unilevel.Models;

public class PermissionSeeder
{
    private readonly AppDbContext _dbContext;
    private readonly IActionDescriptorCollectionProvider _actionDescriptorCollectionProvider;

    public PermissionSeeder(AppDbContext dbContext, IActionDescriptorCollectionProvider actionDescriptorCollectionProvider)
    {
        _dbContext = dbContext;
        _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
    }

    public void SeedPermissions()
    {
        // Lấy tất cả action descriptors
        var actionDescriptors = _actionDescriptorCollectionProvider.ActionDescriptors.Items
            .OfType<ControllerActionDescriptor>();

        var permissions = actionDescriptors
            .SelectMany(ad => ad.MethodInfo
                .GetCustomAttributes(typeof(CustomAuthorizeAttribute), true)
                .Cast<CustomAuthorizeAttribute>())
            .Select(attr => attr._requiredPermission)
            .Distinct();

        foreach (var permission in permissions)
        {
            if (!_dbContext.Permission.Any(p => p.PermissionName == permission))
            {
                _dbContext.Permission.Add(new Permission
                {
                    
                    PermissionName = permission,
                 
                });
            }
        }

        _dbContext.SaveChanges();
    }
}
