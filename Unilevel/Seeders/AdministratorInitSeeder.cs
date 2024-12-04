using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Unilevel.Models;

public static class AdministratorInitSeeder
{
    public static async Task SeedAdminUser(IServiceProvider serviceProvider)
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
        var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();

        var adminEmail = "admin@admin.admin";
        var adminPassword = "Abc123@";

        if (!await roleManager.RoleExistsAsync("Administrator"))
        {
            var adminRole = new Role { Name = "Administrator", NormalizedName = "ADMINISTRATOR", GroupRoleId = 1 };
            await roleManager.CreateAsync(adminRole);
        }

        if (await userManager.FindByEmailAsync(adminEmail) == null)
        {
            var adminUser = new User
            {
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true,
                PathPicture = null,
                Address = "Admin Address",
                JoinDate = DateTime.UtcNow,
                IsActive = true
            };

            var result = await userManager.CreateAsync(adminUser, adminPassword);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, "Administrator");
            }
        }
    }
}
