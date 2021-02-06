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
    public class ApprenticesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApprenticesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Apprentices
        public async Task<IActionResult> Index()
        {
            return View(await _context.Apprentices.ToListAsync());
        }

        // GET: Apprentices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apprentice = await _context.Apprentices
                .FirstOrDefaultAsync(m => m.ApprenticeId == id);
            if (apprentice == null)
            {
                return NotFound();
            }

            return View(apprentice);
        }

        // GET: Apprentices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Apprentices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApprenticeId,Specialism,FirstName,LastName,JobTitle,Employer,Email")] Apprentice apprentice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apprentice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(apprentice);
        }

        // GET: Apprentices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apprentice = await _context.Apprentices.FindAsync(id);
            if (apprentice == null)
            {
                return NotFound();
            }
            return View(apprentice);
        }

        // POST: Apprentices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApprenticeId,Specialism,FirstName,LastName,JobTitle,Employer,Email")] Apprentice apprentice)
        {
            if (id != apprentice.ApprenticeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apprentice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApprenticeExists(apprentice.ApprenticeId))
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
            return View(apprentice);
        }

        // GET: Apprentices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apprentice = await _context.Apprentices
                .FirstOrDefaultAsync(m => m.ApprenticeId == id);
            if (apprentice == null)
            {
                return NotFound();
            }

            return View(apprentice);
        }

        // POST: Apprentices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var apprentice = await _context.Apprentices.FindAsync(id);
            _context.Apprentices.Remove(apprentice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApprenticeExists(int id)
        {
            return _context.Apprentices.Any(e => e.ApprenticeId == id);
        }
    }
}
