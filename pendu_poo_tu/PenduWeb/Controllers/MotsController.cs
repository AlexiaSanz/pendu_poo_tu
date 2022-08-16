using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PenduWeb.Data;

namespace PenduWeb.Controllers
{
    public class MotsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MotsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Mots
        public async Task<IActionResult> Index()
        {
              return _context.Mots != null ? 
                          View(await _context.Mots.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Mots'  is null.");
        }

        // GET: Mots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Mots == null)
            {
                return NotFound();
            }

            var mot = await _context.Mots
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mot == null)
            {
                return NotFound();
            }

            return View(mot);
        }

        // GET: Mots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Contenu")] Mot mot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mot);
        }

        // GET: Mots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Mots == null)
            {
                return NotFound();
            }

            var mot = await _context.Mots.FindAsync(id);
            if (mot == null)
            {
                return NotFound();
            }
            return View(mot);
        }

        // POST: Mots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Contenu")] Mot mot)
        {
            if (id != mot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotExists(mot.Id))
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
            return View(mot);
        }

        // GET: Mots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Mots == null)
            {
                return NotFound();
            }

            var mot = await _context.Mots
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mot == null)
            {
                return NotFound();
            }

            return View(mot);
        }

        // POST: Mots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Mots == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Mots'  is null.");
            }
            var mot = await _context.Mots.FindAsync(id);
            if (mot != null)
            {
                _context.Mots.Remove(mot);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotExists(int id)
        {
          return (_context.Mots?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
