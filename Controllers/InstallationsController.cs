using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RJ35.Data;
using RJ35.Models.Products.ViewModels;

namespace RJ35.Controllers
{
    public class InstallationsController : Controller
    {
        private readonly RJ35Context _context;

        public InstallationsController(RJ35Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Cable(int? id)
        {
            if (id == null)
            {
                return View(await _context.Cables.Join(_context.Products, un => un.ProductId, n => n.ProductId, (un, n) => new { un, n }).Select(x => new CableViewModel {Cable = x.un, Product = x.n}).ToListAsync());
            }
            else if (_context.Cables.Any(c => c.ProductId == id))
            {
                return View("CableDetails",await _context.Cables.Where(c => c.ProductId == id).Join(_context.Products, un => un.ProductId, n => n.ProductId, (un, n) => new { un, n }).Select(x => new CableViewModel {Cable = x.un, Product = x.n}).ToListAsync());
            } else {
                return NotFound();
            }
        }

        public IActionResult Index() {
            return View();
        }

    }
}
