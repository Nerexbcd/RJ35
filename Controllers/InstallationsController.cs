using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RJ35.Data;
using RJ35.Models.Products.ViewModels;
using RJ35.Services;

namespace RJ35.Controllers
{
    public class InstallationsController : Controller
    {
        private readonly RJ35Context _context;
        private readonly IProductService _productService;

        public InstallationsController(RJ35Context context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        public async Task<IActionResult> Cable(int? id)
        {
            if (id == null)
            {
                return View(await _context.Cables.Join(_context.Products, un => un.ProductId, n => n.ProductId, (cable, product) => new CableViewModel(product, _productService.GetProductRating(product.ProductId) , cable)).ToListAsync());
            }
            else if (_context.Cables.Any(c => c.ProductId == id))
            {
                return View("CableDetails",await _context.Cables.Where(c => c.ProductId == id).Join(_context.Products, un => un.ProductId, n => n.ProductId, (cable, product) => new CableViewModel(product, _productService.GetProductRating(product.ProductId) , cable)).ToListAsync());
            } else {
                return NotFound();
            }
        }

        public IActionResult Index() {
            return View();
        }

    }
}
