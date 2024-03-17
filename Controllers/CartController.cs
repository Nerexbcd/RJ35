using Microsoft.AspNetCore.Mvc;
using RJ35.Data;
using Microsoft.AspNetCore.Authorization;

namespace RJ35.Controllers;

[Authorize]
public class CartController : Controller
{
    private readonly RJ35Context _context;

    public CartController(RJ35Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AddToCart()
    {
        return View();
    }


}
