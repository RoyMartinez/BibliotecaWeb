using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class NacionalidadesController : Controller
    {
        private readonly BibliotecaWebContext _context;

        public NacionalidadesController(BibliotecaWebContext context)
        {
            _context = context;
        }

        // GET: Nacionalidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nacionalidad.ToListAsync());
        }

        // GET: Nacionalidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nacionalidad = await _context.Nacionalidad
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nacionalidad == null)
            {
                return NotFound();
            }

            return View(nacionalidad);
        }

        // GET: Nacionalidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nacionalidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nacionalidad1")] Nacionalidad nacionalidad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nacionalidad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nacionalidad);
        }

        // GET: Nacionalidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nacionalidad = await _context.Nacionalidad.FindAsync(id);
            if (nacionalidad == null)
            {
                return NotFound();
            }
            return View(nacionalidad);
        }

        // POST: Nacionalidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nacionalidad1")] Nacionalidad nacionalidad)
        {
            if (id != nacionalidad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nacionalidad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NacionalidadExists(nacionalidad.Id))
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
            return View(nacionalidad);
        }

        // GET: Nacionalidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nacionalidad = await _context.Nacionalidad
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nacionalidad == null)
            {
                return NotFound();
            }

            return View(nacionalidad);
        }

        // POST: Nacionalidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nacionalidad = await _context.Nacionalidad.FindAsync(id);
            _context.Nacionalidad.Remove(nacionalidad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NacionalidadExists(int id)
        {
            return _context.Nacionalidad.Any(e => e.Id == id);
        }
    }
}
