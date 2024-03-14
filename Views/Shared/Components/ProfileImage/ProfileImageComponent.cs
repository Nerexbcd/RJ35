using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using RJ35.Data.Identity;
using System.Security.Claims;

public class ProfileImageViewComponent : ViewComponent
{
    private readonly UserManager<RJ35WebUser> _userManager;

    public ProfileImageViewComponent(UserManager<RJ35WebUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        var user = await _userManager.FindByIdAsync(userId);
        var profileImg = user?.ProfileImg;

        return View(model: profileImg);
    }
}