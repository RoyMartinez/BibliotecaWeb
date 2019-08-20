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
    public class PrestamosController : Controller
    {
        private readonly BibliotecaWebContext _context;

        public PrestamosController(BibliotecaWebContext context)
        {
            _context = context;
        }

        // GET: Prestamos
        public async Task<IActionResult> Index()
        {
            var bibliotecaWebContext = _context.Prestamo.Include(p => p.EstudianteNavigation).Include(p => p.LibroNavigation);
            return View(await bibliotecaWebContext.ToListAsync());
        }

        // GET: Prestamos/Details/5
        public async Task<IActionResult> Details(int? id1,int? id2)
        {
            if (id1 == null && id2 == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamo
                .Include(p => p.EstudianteNavigation)
                .Include(p => p.LibroNavigation)
                .FirstOrDefaultAsync(m => m.Estudiante == id1 && m.Libro == id2);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // GET: Prestamos/Create
        public IActionResult Create()
        {
            ViewData["Estudiante"] = new SelectList(_context.Estudiante, "Id", "Nombre");
            ViewData["Libro"] = new SelectList(_context.Libro, "Id", "Titulo");
            return View();
        }

        // POST: Prestamos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Estudiante,Libro,FechaPrestamo,FechaDevolucion,Devuelto")] Prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestamo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Estudiante"] = new SelectList(_context.Estudiante, "Id", "Nombre", prestamo.Estudiante);
            ViewData["Libro"] = new SelectList(_context.Libro, "Id", "Titulo", prestamo.Libro);
            return View(prestamo);
        }

        // GET: Prestamos/Edit/5
        public async Task<IActionResult> Edit(int? id1, int? id2)
        {
            if (id1 == null && id2 == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamo.FindAsync(id1,id2);
            if (prestamo == null)
            {
                return NotFound();
            }
            ViewData["Estudiante"] = new SelectList(_context.Estudiante, "Id", "Nombre", prestamo.Estudiante);
            ViewData["Libro"] = new SelectList(_context.Libro, "Id", "Titulo", prestamo.Libro);
            return View(prestamo);
        }

        // POST: Prestamos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id1, int? id2, [Bind("Estudiante,Libro,FechaPrestamo,FechaDevolucion,Devuelto")] Prestamo prestamo)
        {
            if (id1 != prestamo.Estudiante && id2 != prestamo.Libro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestamoExists(prestamo.Estudiante,prestamo.Libro))
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
            ViewData["Estudiante"] = new SelectList(_context.Estudiante, "Id", "Nombre", prestamo.Estudiante);
            ViewData["Libro"] = new SelectList(_context.Libro, "Id", "Titulo", prestamo.Libro);
            IList<SelectListItem> devuelto = new List<SelectListItem>
            {
                new SelectListItem{Text = "S", Value = "S"},
                new SelectListItem{Text = "N", Value = "N"}
            };
            ViewBag["Devuelto"] = devuelto;
            return View(prestamo);
        }

        // GET: Prestamos/Delete/5
        public async Task<IActionResult> Delete(int? id1, int? id2)
        {
            if (id1 == null && id2 == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamo
                .Include(p => p.EstudianteNavigation)
                .Include(p => p.LibroNavigation)
                .FirstOrDefaultAsync(m => m.Estudiante == id1 && m.Libro == id2);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // POST: Prestamos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id1, int? id2)
        {
            var prestamo = await _context.Prestamo.FindAsync(id1,id2);
            _context.Prestamo.Remove(prestamo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestamoExists(int? id1, int? id2)
        {
            return _context.Prestamo.Any(e => e.Estudiante == id1 && e.Libro == id2);
        }
    }
}
