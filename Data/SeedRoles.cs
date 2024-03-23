using Microsoft.AspNetCore.Identity;

namespace RJ35.Data;

public static class SeedRoles
{
    public static async Task Initialize(RoleManager<IdentityRole> roleManager)
    {
        var roles = new[] { "Admin", "Warehouse", "Delivery", "User" };

        foreach (var role in roles)
        {
            if (!roleManager.RoleExistsAsync(role).Result)
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }
    }
}