using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using RJ35.Data;

namespace RJ35.Controllers;

[Authorize]
public class OrdersController : Controller
{
    private readonly RJ35Context _context;

    public OrdersController(RJ35Context context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int? _id)
    {
        if (_id == null) {
            return View(await _context.Order.ToListAsync());
        } else {
            return View("OrderDetails",await _context.Order.Where(c => c.OrderID == _id).ToListAsync());
        }
    }
}