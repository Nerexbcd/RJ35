using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RJ35.Data;
using RJ35.Models.Products.ViewModels;
using RJ35.Services;

namespace RJ35.Controllers;

public class DevicesController : Controller
{
    private readonly RJ35Context _context;
    private readonly IProductService _productService;

    public DevicesController(RJ35Context context, IProductService productService)
    {
        _context = context;
        _productService = productService;
    }

    public async Task<IActionResult> Index(int? _id)
    {
        if (_id == null) {
            string brand = HttpContext.Request.Query["brand"].ToString();
            
            return View(await _context.Products.Select(x => new ProductViewModel(x, _productService.GetProductRating(x.ProductId))).ToListAsync());
            // return View(await _context.Devices.Where(c => c.Brand == brand).ToListAsync());
        } else {
            return View();
            // return View("OrderDetails",await _context.Devices.Where(c => c.Id == _id).ToListAsync());
        }
    }
}

