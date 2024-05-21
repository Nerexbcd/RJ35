using System.Data.Entity;
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

    public async Task<IActionResult> Index()
    {
        string brand = HttpContext.Request.Query["brand"].ToString();
        
        return View(await _context.Devices.Join(_context.Products, un => un.ProductId, n => n.ProductId, (device, product) => new DeviceViewModel(product, _productService.GetProductRating(product.ProductId) , device)).ToListAsync());
        // return View(await _context.Devices.Where(c => c.Brand == brand).ToListAsync());
    }


    public async Task<IActionResult> Details(int? id) {
        if (id == null)
        {
            return NotFound();
        }

        if (_context.Devices.Any(c => c.ProductId == id))
        {
            return View((await _context.Devices.Where(c => c.ProductId == id).Join(_context.Products, un => un.ProductId, n => n.ProductId, (device, product) => new DeviceViewModel(product, _productService.GetProductRating(product.ProductId) , device)).ToListAsync()).First());
        }

        return NotFound();
    }
}

