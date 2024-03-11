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
    public class CableController : Controller
    {
        
        private readonly RJ35Context _context;

        public CableController(RJ35Context context)
        {
            _context = context;
        }

        // GET: Cable
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cable.ToListAsync());
        }

        // GET: Cable/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cable = await _context.Cable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cable == null)
            {
                return NotFound();
            }

            return View(cable);
        }

        // GET: Cable/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cable/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,CableType,Category,MetersAvaliable,PriceMeter")] Cable cable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cable);
        }

        // GET: Cable/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cable = await _context.Cable.FindAsync(id);
            if (cable == null)
            {
                return NotFound();
            }
            return View(cable);
        }

        // POST: Cable/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CableType,Category,MetersAvaliable,PriceMeter")] Cable cable)
        {
            if (id != cable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CableExists(cable.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cable);
        }

        // GET: Cable/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cable = await _context.Cable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cable == null)
            {
                return NotFound();
            }

            return View(cable);
        }

        // POST: Cable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cable = await _context.Cable.FindAsync(id);
            if (cable != null)
            {
                _context.Cable.Remove(cable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CableExists(int id)
        {
            return _context.Cable.Any(e => e.Id == id);
        }
    }
}
