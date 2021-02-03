using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnterpriseSystemsDevelopment_EPortfolio.Data;
using EnterpriseSystemsDevelopment_EPortfolio.Models;

namespace EnterpriseSystemsDevelopment_EPortfolio.Controllers
{
    public class EvidencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EvidencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Evidences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Evidence.ToListAsync());
        }

        // GET: Evidences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evidence = await _context.Evidence
                .FirstOrDefaultAsync(m => m.EvidenceId == id);
            if (evidence == null)
            {
                return NotFound();
            }

            return View(evidence);
        }

        // GET: Evidences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Evidences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EvidenceId,Name,FileTypes,Description")] Evidence evidence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evidence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(evidence);
        }

        // GET: Evidences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evidence = await _context.Evidence.FindAsync(id);
            if (evidence == null)
            {
                return NotFound();
            }
            return View(evidence);
        }

        // POST: Evidences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EvidenceId,Name,FileTypes,Description")] Evidence evidence)
        {
            if (id != evidence.EvidenceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(evidence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EvidenceExists(evidence.EvidenceId))
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
            return View(evidence);
        }

        // GET: Evidences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evidence = await _context.Evidence
                .FirstOrDefaultAsync(m => m.EvidenceId == id);
            if (evidence == null)
            {
                return NotFound();
            }

            return View(evidence);
        }

        // POST: Evidences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var evidence = await _context.Evidence.FindAsync(id);
            _context.Evidence.Remove(evidence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EvidenceExists(int id)
        {
            return _context.Evidence.Any(e => e.EvidenceId == id);
        }
    }
}
