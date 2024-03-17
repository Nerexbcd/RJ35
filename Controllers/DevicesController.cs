using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RJ35.Data;

namespace RJ35.Controllers;

public class DevicesController : Controller
{
    private readonly RJ35Context _context;

    public DevicesController(RJ35Context context)
    {
        _context = context;
    }

    // public async Task<IActionResult> Index(int? _id)
    // {
    //     if (_id == null) {
    //         string brand = HttpContext.Request.Query["brand"].ToString();
            
    //         return View(await _context.Devices.Where(c => c.Brand == brand).ToListAsync());
    //     } else {
    //         return View("OrderDetails",await _context.Devices.Where(c => c.Id == _id).ToListAsync());
    //     }
    // }
}

