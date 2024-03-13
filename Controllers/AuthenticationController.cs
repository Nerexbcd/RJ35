using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Azure;

namespace RJ35.Controllers;



[Authorize]
public class AuthenticationController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(string username, string password)
    {   

        HttpContext.Session.SetInt32("loggedIn",1);
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Remove("loggedIn");
        return RedirectToAction("Index","Home");
    }
}