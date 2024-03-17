using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace RJ35.Controllers;

[Authorize]
public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}