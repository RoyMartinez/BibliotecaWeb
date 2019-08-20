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
    public class LibroXautorsController : Controller
    {
        private readonly BibliotecaWebContext _context;

        public LibroXautorsController(BibliotecaWebContext context)
        {
            _context = context;
        }

        // GET: LibroXautors
        public async Task<IActionResult> Index()
        {
            var bibliotecaWebContext = _context.LibroXautor.Include(l => l.AutorNavigation).Include(l => l.LibroNavigation);
            return View(await bibliotecaWebContext.ToListAsync());
        }

        // GET: LibroXautors/Details/5
        public async Task<IActionResult> Details(int? id1,int? id2)
        {
            if (id1 == null && id2 == null)
            {
                return NotFound();
            }

            var libroXautor = await _context.LibroXautor
                .Include(l => l.AutorNavigation)
                .Include(l => l.LibroNavigation)
                .FirstOrDefaultAsync(m => m.Autor == id1 && m.Libro == id2);
            if (libroXautor == null)
            {
                return NotFound();
            }

            return View(libroXautor);
        }

        // GET: LibroXautors/Create
        public IActionResult Create()
        {
            ViewData["Autor"] = new SelectList(_context.Autor, "Id", "Nombre");
            ViewData["Libro"] = new SelectList(_context.Libro, "Id", "Titulo");
            return View();
        }

        // POST: LibroXautors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Autor,Libro")] LibroXautor libroXautor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(libroXautor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Autor"] = new SelectList(_context.Autor, "Id", "Nombre", libroXautor.Autor);
            ViewData["Libro"] = new SelectList(_context.Libro, "Id", "Titulo", libroXautor.Libro);
            return View(libroXautor);
        }

        // GET: LibroXautors/Edit/5
        public async Task<IActionResult> Edit(int? id1,int? id2)
        {
            if (id1 == null && id2==null)
            {
                return NotFound();
            }

            var libroXautor = await _context.LibroXautor.FindAsync(id1,id2);
            if (libroXautor == null)
            {
                return NotFound();
            }
            ViewData["Autor"] = new SelectList(_context.Autor, "Id", "Nombre", libroXautor.Autor);
            ViewData["Libro"] = new SelectList(_context.Libro, "Id", "Titulo", libroXautor.Libro);
            return View(libroXautor);
        }

        // POST: LibroXautors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id1,int id2, [Bind("Autor,Libro")] LibroXautor libroXautor)
        {
            if (id1 != libroXautor.Autor && id2 != libroXautor.Libro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(libroXautor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibroXautorExists(libroXautor.Autor,libroXautor.Libro))
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
            ViewData["Autor"] = new SelectList(_context.Autor, "Id", "Nombre", libroXautor.Autor);
            ViewData["Libro"] = new SelectList(_context.Libro, "Id", "Titulo", libroXautor.Libro);
            return View(libroXautor);
        }

        // GET: LibroXautors/Delete/5
        public async Task<IActionResult> Delete(int? id1,int? id2)
        {
            if (id1 == null && id2 == null)
            {
                return NotFound();
            }

            var libroXautor = await _context.LibroXautor
                .Include(l => l.AutorNavigation)
                .Include(l => l.LibroNavigation)
                .FirstOrDefaultAsync(m => m.Autor == id1 && m.Libro == id2);
            if (libroXautor == null)
            {
                return NotFound();
            }

            return View(libroXautor);
        }

        // POST: LibroXautors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id1,int? id2)
        {
            var libroXautor = await _context.LibroXautor.FindAsync(id1,id2);
            _context.LibroXautor.Remove(libroXautor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LibroXautorExists(int id1,int id2)
        {
            return _context.LibroXautor.Any(e => e.Autor == id1 && e.Libro == id2);
        }
    }
}
