﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LOCADORA.Models;

namespace LOCADORA.Controllers
{
    public class CarrosController : Controller
    {
        private readonly Contexto _context;

        public CarrosController(Contexto context)
        {
            _context = context;
        }

        // GET: Carros
        public async Task<IActionResult> Index()
        {
              return _context.Carros != null ? 
                          View(await _context.Carros.ToListAsync()) :
                          Problem("Entity set 'Contexto.Carros'  is null.");
        }

        // GET: Carros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Carros == null)
            {
                return NotFound();
            }

            var carros = await _context.Carros
                .FirstOrDefaultAsync(m => m.id == id);
            if (carros == null)
            {
                return NotFound();
            }

            return View(carros);
        }

        // GET: Carros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,modelo,motor,disponibilidade,valor")] Carros carros)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carros);
        }

        // GET: Carros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Carros == null)
            {
                return NotFound();
            }

            var carros = await _context.Carros.FindAsync(id);
            if (carros == null)
            {
                return NotFound();
            }
            return View(carros);
        }

        // POST: Carros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,modelo,motor,disponibilidade,valor")] Carros carros)
        {
            if (id != carros.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarrosExists(carros.id))
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
            return View(carros);
        }

        // GET: Carros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Carros == null)
            {
                return NotFound();
            }

            var carros = await _context.Carros
                .FirstOrDefaultAsync(m => m.id == id);
            if (carros == null)
            {
                return NotFound();
            }

            return View(carros);
        }

        // POST: Carros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Carros == null)
            {
                return Problem("Entity set 'Contexto.Carros'  is null.");
            }
            var carros = await _context.Carros.FindAsync(id);
            if (carros != null)
            {
                _context.Carros.Remove(carros);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarrosExists(int id)
        {
          return (_context.Carros?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
