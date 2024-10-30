using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PANCHI_PROYECTO1.Data;
using PANCHI_PROYECTO1.Models;

namespace PANCHI_PROYECTO1.Controllers
{
    public class SPanchiController : Controller
    {
        private readonly PANCHI_PROYECTO1Context _context;

        public SPanchiController(PANCHI_PROYECTO1Context context)
        {
            _context = context;
        }

        // GET: SPanchis
        public async Task<IActionResult> Index()
        {
            return View(await _context.SPanchi.ToListAsync());
        }

        // GET: SPanchis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sPanchi = await _context.SPanchi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sPanchi == null)
            {
                return NotFound();
            }

            return View(sPanchi);
        }

        // GET: SPanchis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SPanchis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Peso,Extranjero,Fecha")] SPanchi sPanchi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sPanchi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sPanchi);
        }

        // GET: SPanchis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sPanchi = await _context.SPanchi.FindAsync(id);
            if (sPanchi == null)
            {
                return NotFound();
            }
            return View(sPanchi);
        }

        // POST: SPanchis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Peso,Extranjero,Fecha")] SPanchi sPanchi)
        {
            if (id != sPanchi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sPanchi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SPanchiExists(sPanchi.Id))
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
            return View(sPanchi);
        }

        // GET: SPanchis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sPanchi = await _context.SPanchi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sPanchi == null)
            {
                return NotFound();
            }

            return View(sPanchi);
        }

        // POST: SPanchis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sPanchi = await _context.SPanchi.FindAsync(id);
            if (sPanchi != null)
            {
                _context.SPanchi.Remove(sPanchi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SPanchiExists(int id)
        {
            return _context.SPanchi.Any(e => e.Id == id);
        }
    }
}
