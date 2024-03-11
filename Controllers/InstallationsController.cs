using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RJ35.Data;
using RJ35.Models;

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
                return View(await _context.Cable.ToListAsync());
            }
            else
            {
                return View("CableDetails",await _context.Cable.Where(c => c.Id == id).ToListAsync());
            }
            
        }

        public IActionResult Index() {
            return View();
        }

        // public IActionResult Cable()
        // {
        //     return View();
        // }

        // public IActionResult Racks()
        // {
        //     return View();
        // }

        // public IActionResult RackMaterial()
        // {
        //     return View();
        // }

    }
}
