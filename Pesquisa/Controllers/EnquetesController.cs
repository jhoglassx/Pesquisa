using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pesquisa.Models;

namespace Pesquisa.Controllers
{
    public class EnquetesController : Controller
    {
        private readonly Context _context;

        public EnquetesController(Context context)
        {
            _context = context;
        }

        // GET: Enquetes
        public async Task<IActionResult> Index()
        {
            var context = _context.Enquetes.Include(e => e.ConvenioList).Include(e => e.FaixaIdades).Include(e => e.FaixaSalario).Include(e => e.MotivoEmprestimos);
            return View(await context.ToListAsync());
        }

        // GET: Enquetes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquete = await _context.Enquetes
                .Include(e => e.ConvenioList)
                .Include(e => e.FaixaIdades)
                .Include(e => e.FaixaSalario)
                .Include(e => e.MotivoEmprestimos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enquete == null)
            {
                return NotFound();
            }

            return View(enquete);
        }

        // GET: Enquetes/Create
        public IActionResult Create()
        {
            ViewData["ConvenioListId"] = new SelectList(_context.ConvenioLists, "Id", "ConvenioNome");
            ViewData["FaixaIdadeId"] = new SelectList(_context.FaixaIdades, "Id", "FaixadeIdade");
            ViewData["FaixaSalarioId"] = new SelectList(_context.FaixaSalario, "Id", "FaixaSalarial");
            ViewData["MotivoEmprestimoId"] = new SelectList(_context.MotivoEmprestimos, "Id", "EmprestimoMotivo");
            return View();
        }

        // POST: Enquetes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,FaixaSalarioId,MotivoEmprestimoId,ConvenioListId,FaixaIdadeId")] Enquete enquete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enquete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConvenioListId"] = new SelectList(_context.ConvenioLists, "Id", "ConvenioNome", enquete.ConvenioListId);
            ViewData["FaixaIdadeId"] = new SelectList(_context.FaixaIdades, "Id", "FaixadeIdade", enquete.FaixaIdadeId);
            ViewData["FaixaSalarioId"] = new SelectList(_context.FaixaSalario, "Id", "FaixaSalarial", enquete.FaixaSalarioId);
            ViewData["MotivoEmprestimoId"] = new SelectList(_context.MotivoEmprestimos, "Id", "EmprestimoMotivo", enquete.MotivoEmprestimoId);
            return View(enquete);
        }

        // GET: Enquetes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquete = await _context.Enquetes.FindAsync(id);
            if (enquete == null)
            {
                return NotFound();
            }
            ViewData["ConvenioListId"] = new SelectList(_context.ConvenioLists, "Id", "ConvenioNome", enquete.ConvenioListId);
            ViewData["FaixaIdadeId"] = new SelectList(_context.FaixaIdades, "Id", "FaixadeIdade", enquete.FaixaIdadeId);
            ViewData["FaixaSalarioId"] = new SelectList(_context.FaixaSalario, "Id", "FaixaSalarial", enquete.FaixaSalarioId);
            ViewData["MotivoEmprestimoId"] = new SelectList(_context.MotivoEmprestimos, "Id", "EmprestimoMotivo", enquete.MotivoEmprestimoId);
            return View(enquete);
        }

        // POST: Enquetes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,FaixaSalarioId,MotivoEmprestimoId,ConvenioListId,FaixaIdadeId")] Enquete enquete)
        {
            if (id != enquete.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enquete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnqueteExists(enquete.Id))
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
            ViewData["ConvenioListId"] = new SelectList(_context.ConvenioLists, "Id", "ConvenioNome", enquete.ConvenioListId);
            ViewData["FaixaIdadeId"] = new SelectList(_context.FaixaIdades, "Id", "FaixadeIdade", enquete.FaixaIdadeId);
            ViewData["FaixaSalarioId"] = new SelectList(_context.FaixaSalario, "Id", "FaixaSalarial", enquete.FaixaSalarioId);
            ViewData["MotivoEmprestimoId"] = new SelectList(_context.MotivoEmprestimos, "Id", "EmprestimoMotivo", enquete.MotivoEmprestimoId);
            return View(enquete);
        }

        // GET: Enquetes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquete = await _context.Enquetes
                .Include(e => e.ConvenioList)
                .Include(e => e.FaixaIdades)
                .Include(e => e.FaixaSalario)
                .Include(e => e.MotivoEmprestimos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enquete == null)
            {
                return NotFound();
            }

            return View(enquete);
        }

        // POST: Enquetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enquete = await _context.Enquetes.FindAsync(id);
            _context.Enquetes.Remove(enquete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnqueteExists(int id)
        {
            return _context.Enquetes.Any(e => e.Id == id);
        }
    }
}
