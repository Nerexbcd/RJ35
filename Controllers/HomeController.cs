using Microsoft.AspNetCore.Mvc;
using RJ35.Data;
using RJ35.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using RJ35.Models.Products.ViewModels;
using RJ35.Services;

namespace RJ35.Controllers;

[AllowAnonymous]
public class HomeController : Controller
{
    private readonly RJ35Context _context;
    private readonly IProductService _productService;

    public HomeController(RJ35Context context, IProductService productService)
    {
        _context = context;
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Products.OrderByDescending(x => x.CreatedAt).Take(8).Select(x => new ProductViewModel(x, _productService.GetProductRating(x.ProductId))).ToListAsync());
    }

    // Only for Development
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult StatusPage(int id = 0)
    {
        if (id == 404)
        {
            return View("NotFoundPage");
        }
        ViewBag.StatusCode = id;
        ViewBag.StatusMessage = $"status happened: {id}";
        return View();
    }
}
