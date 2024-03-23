using Microsoft.AspNetCore.Identity;
using RJ35.Models;

namespace RJ35.Data;

public static class SeedFirstAdmin
{
    public static async Task Initialize(UserManager<RJ35WebUser> userManager)
    {
        if (userManager.Users.Count() == 0) {
            var user = new RJ35WebUser { UserName = "admin@test.pt", Email = "admin@test.pt" };
            await userManager.CreateAsync(user, "Admin123#");
            await userManager.AddToRoleAsync(user, "User");
            await userManager.AddToRoleAsync(user, "Admin");
        }
    }
}