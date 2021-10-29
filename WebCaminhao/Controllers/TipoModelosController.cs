using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCaminhao.Data;
using WebCaminhao.Models;

namespace WebCaminhao.Controllers
{
    public class TipoModelosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoModelosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoModelos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoModelo.ToListAsync());
        }

        // GET: TipoModelos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoModelo = await _context.TipoModelo
                .FirstOrDefaultAsync(m => m.Modelo == id);
            if (tipoModelo == null)
            {
                return NotFound();
            }

            return View(tipoModelo);
        }

        // GET: TipoModelos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoModelos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Modelo")] TipoModelo tipoModelo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoModelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoModelo);
        }

        // GET: TipoModelos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoModelo = await _context.TipoModelo.FindAsync(id);
            if (tipoModelo == null)
            {
                return NotFound();
            }
            return View(tipoModelo);
        }

        // POST: TipoModelos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Modelo")] TipoModelo tipoModelo)
        {
            if (id != tipoModelo.Modelo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoModelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoModeloExists(tipoModelo.Modelo))
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
            return View(tipoModelo);
        }

        // GET: TipoModelos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoModelo = await _context.TipoModelo
                .FirstOrDefaultAsync(m => m.Modelo == id);
            if (tipoModelo == null)
            {
                return NotFound();
            }

            return View(tipoModelo);
        }

        // POST: TipoModelos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tipoModelo = await _context.TipoModelo.FindAsync(id);
            _context.TipoModelo.Remove(tipoModelo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoModeloExists(string id)
        {
            return _context.TipoModelo.Any(e => e.Modelo == id);
        }
    }
}
