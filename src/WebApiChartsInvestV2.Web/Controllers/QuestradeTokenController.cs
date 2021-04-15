using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApiChartsInvestV2.Data.Config;
using WebApiChartsInvestV2.Model.Entities;

namespace WebApiChartsInvestV2.Web.Controllers
{
    public class QuestradeTokenController : Controller
    {
        private readonly ContextBase _context;

        public QuestradeTokenController(ContextBase context)
        {
            _context = context;
        }

        // GET: QuestradeToken
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestradeToken.ToListAsync());
        }

        // GET: QuestradeToken/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questradeToken = await _context.QuestradeToken
                .FirstOrDefaultAsync(m => m.QuestradeTokenId == id);
            if (questradeToken == null)
            {
                return NotFound();
            }

            return View(questradeToken);
        }

        // GET: QuestradeToken/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestradeToken/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestradeTokenId,Token,Validade,IsValid")] QuestradeToken questradeToken)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questradeToken);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(questradeToken);
        }

        // GET: QuestradeToken/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questradeToken = await _context.QuestradeToken.FindAsync(id);
            if (questradeToken == null)
            {
                return NotFound();
            }
            return View(questradeToken);
        }

        // POST: QuestradeToken/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestradeTokenId,Token,Validade,IsValid")] QuestradeToken questradeToken)
        {
            if (id != questradeToken.QuestradeTokenId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questradeToken);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestradeTokenExists(questradeToken.QuestradeTokenId))
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
            return View(questradeToken);
        }

        // GET: QuestradeToken/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questradeToken = await _context.QuestradeToken
                .FirstOrDefaultAsync(m => m.QuestradeTokenId == id);
            if (questradeToken == null)
            {
                return NotFound();
            }

            return View(questradeToken);
        }

        // POST: QuestradeToken/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questradeToken = await _context.QuestradeToken.FindAsync(id);
            _context.QuestradeToken.Remove(questradeToken);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestradeTokenExists(int id)
        {
            return _context.QuestradeToken.Any(e => e.QuestradeTokenId == id);
        }
    }
}
