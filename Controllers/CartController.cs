using Microsoft.AspNetCore.Mvc;
using RJ35.Data;
using Microsoft.AspNetCore.Authorization;
using RJ35.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using RJ35.Models.Products;

namespace RJ35.Controllers;

[Authorize]
public class CartController : Controller
{
    private readonly RJ35Context _context;

    public CartController(RJ35Context context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.ProductsCarts.Where(x => x.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Join(_context.Products, x => x.ProductId, x => x.ProductId, (cart, product) => new ProductCartViewModel(cart, product)).ToListAsync());
    }

    public IActionResult Add(int? id)
    {
        int quantity = HttpContext.Request.Query.ContainsKey("quantity") ? Convert.ToInt32(HttpContext.Request.Query["quantity"]) : 1;

        ProductsCart? product = _context.ProductsCarts.Find(User.FindFirstValue(ClaimTypes.NameIdentifier), id);

        if (product != null)
        {
            product.Quantity += quantity;
        } else {
            _context.ProductsCarts.Add(new ProductsCart
                {
                    UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    User = _context.Users.Find(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                    ProductId = (int)id,
                    Product = _context.Products.Find(id),
                    Quantity = quantity
                });
        }

        _context.SaveChanges();
        return RedirectToAction("Index", "Cart");
    }

    public IActionResult Remove(int? id)
    {
        ProductsCart? product = _context.ProductsCarts.Find(User.FindFirstValue(ClaimTypes.NameIdentifier), id);

        if (product != null)
        {
            product.Quantity--;
            if (product.Quantity == 0)
            {
                _context.ProductsCarts.Remove(product);
            }
        }

        _context.SaveChanges();
        return RedirectToAction("Index", "Cart");
    }

    public IActionResult Delete(int? id)
    {
        ProductsCart? product = _context.ProductsCarts.Find(User.FindFirstValue(ClaimTypes.NameIdentifier), id);

        if (product != null)
        {
            _context.ProductsCarts.Remove(product);
            _context.SaveChanges();
        }

        return RedirectToAction("Index", "Cart");
    }


}
