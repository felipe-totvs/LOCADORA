using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LOCADORA.Models;

namespace LOCADORA.Controllers
{
    public class ManutencaoController : Controller
    {
        private readonly Contexto _context;

        public ManutencaoController(Contexto context)
        {
            _context = context;
        }

        // GET: Manutencao
        public async Task<IActionResult> Index()
        {
              return _context.Manutencao != null ? 
                          View(await _context.Manutencao.ToListAsync()) :
                          Problem("Entity set 'Contexto.Manutencao'  is null.");
        }

        // GET: Manutencao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Manutencao == null)
            {
                return NotFound();
            }

            var manutencao = await _context.Manutencao
                .FirstOrDefaultAsync(m => m.id == id);
            if (manutencao == null)
            {
                return NotFound();
            }

            return View(manutencao);
        }

        // GET: Manutencao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manutencao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,id_carro,estado")] Manutencao manutencao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manutencao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manutencao);
        }

        // GET: Manutencao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Manutencao == null)
            {
                return NotFound();
            }

            var manutencao = await _context.Manutencao.FindAsync(id);
            if (manutencao == null)
            {
                return NotFound();
            }
            return View(manutencao);
        }

        // POST: Manutencao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,id_carro,estado")] Manutencao manutencao)
        {
            if (id != manutencao.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(manutencao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManutencaoExists(manutencao.id))
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
            return View(manutencao);
        }

        // GET: Manutencao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Manutencao == null)
            {
                return NotFound();
            }

            var manutencao = await _context.Manutencao
                .FirstOrDefaultAsync(m => m.id == id);
            if (manutencao == null)
            {
                return NotFound();
            }

            return View(manutencao);
        }

        // POST: Manutencao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Manutencao == null)
            {
                return Problem("Entity set 'Contexto.Manutencao'  is null.");
            }
            var manutencao = await _context.Manutencao.FindAsync(id);
            if (manutencao != null)
            {
                _context.Manutencao.Remove(manutencao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManutencaoExists(int id)
        {
          return (_context.Manutencao?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
