using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class pnc_modeloController : Controller
    {
        private readonly ApplicationDbContext _context;

        public pnc_modeloController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: pnc_modelo
        public async Task<IActionResult> Index()
        {
            return View(await _context.pnc_modelo.ToListAsync());
        }

        // GET: pnc_modelo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pnc_modelo = await _context.pnc_modelo
                .FirstOrDefaultAsync(m => m.Idpnc == id);
            if (pnc_modelo == null)
            {
                return NotFound();
            }

            return View(pnc_modelo);
        }

        // GET: pnc_modelo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: pnc_modelo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idpnc,fecha_registro,nombre_proceso,producto,accion_inmediata,accion_correctiva,descripcion_accion")] pnc_modelo pnc_modelo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pnc_modelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pnc_modelo);
        }

        // GET: pnc_modelo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pnc_modelo = await _context.pnc_modelo.FindAsync(id);
            if (pnc_modelo == null)
            {
                return NotFound();
            }
            return View(pnc_modelo);
        }

        // POST: pnc_modelo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idpnc,fecha_registro,nombre_proceso,producto,accion_inmediata,accion_correctiva,descripcion_accion")] pnc_modelo pnc_modelo)
        {
            if (id != pnc_modelo.Idpnc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pnc_modelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!pnc_modeloExists(pnc_modelo.Idpnc))
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
            return View(pnc_modelo);
        }

        // GET: pnc_modelo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pnc_modelo = await _context.pnc_modelo
                .FirstOrDefaultAsync(m => m.Idpnc == id);
            if (pnc_modelo == null)
            {
                return NotFound();
            }

            return View(pnc_modelo);
        }

        // POST: pnc_modelo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pnc_modelo = await _context.pnc_modelo.FindAsync(id);
            _context.pnc_modelo.Remove(pnc_modelo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool pnc_modeloExists(int id)
        {
            return _context.pnc_modelo.Any(e => e.Idpnc == id);
        }
    }
}
