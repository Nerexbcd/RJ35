using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using RJ35.Data.Identity;
using System.Security.Claims;
using RJ35.Data;
using Microsoft.EntityFrameworkCore;
using RJ35.Models.ComponentsViewModels;

public class NotificationsDropdownViewComponent : ViewComponent
{
    private readonly UserManager<RJ35WebUser> _userManager;
    private readonly RJ35Context _context;

    public NotificationsDropdownViewComponent(UserManager<RJ35WebUser> userManager,RJ35Context context)
    {
        _userManager = userManager;
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        var user = await _userManager.FindByIdAsync(userId);
        var profileImg = user?.ProfileImg;

        return View(await _context.UserNotifications.Join(_context.Users, un => un.UserId, n => n.Id, (un, n) => new { un, n }).Where(x => x.un.UserId == userId && !x.un.IsRead).Select(x => new NotificationDropdownViewModel(x.un, x.n)).ToListAsync());
    }
}