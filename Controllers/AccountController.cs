using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using RJ35.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using RJ35.Models;

namespace RJ35.Controllers;

[Authorize]
public class AccountController : Controller
{
    private readonly RJ35Context _context;

    public AccountController(RJ35Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(new AccountViewModel(_context.Users.Find(User.FindFirstValue(ClaimTypes.NameIdentifier)), _context.UserAddresses.Where(x => x.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList(), _context.UserCards.Where(x => x.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList()));
    }

    [HttpPost]
    public IActionResult UpdateAccount([FromForm] RJ35WebUser rJ35WebUser)
    {
        var user = _context.Users.Find(User.FindFirstValue(ClaimTypes.NameIdentifier));
        // user.FirstName = rJ35WebUser.FirstName;
        // user.LastName = rJ35WebUser.LastName;
        user.NormalizedEmail = rJ35WebUser.Email.ToUpper();
        user.NormalizedUserName = rJ35WebUser.UserName.ToUpper();
        user.Email = rJ35WebUser.Email;
        user.UserName = rJ35WebUser.UserName;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult AddAddress([FromForm] UserAddress userAddress)
    {
        userAddress.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        _context.UserAddresses.Add(userAddress);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult DeleteAddress(int id)
    {
        var userAddress = _context.UserAddresses.Find(id);
        if (userAddress.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
        {
            _context.UserAddresses.Remove(userAddress);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult AddCard([FromForm] UserCard userCard)
    {
        userCard.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        _context.UserCards.Add(userCard);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}