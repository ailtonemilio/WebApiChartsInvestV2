using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApiChartsInvestV2.Data.Config;
using WebApiChartsInvestV2.Model.Entities;

namespace WebApiChartsInvestV2.Web.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ContextBase _context;

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public PortfolioController(ContextBase context, UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        // GET: Portfolio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Portfolio.ToListAsync());
        }

        // GET: Portfolio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio
                .FirstOrDefaultAsync(m => m.PortfolioId == id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // GET: Portfolio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Portfolio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PortfolioId,PortfolioName")] Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = await userManager.GetUserAsync(User);
                portfolio.UserId = applicationUser.Id;

                _context.Add(portfolio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(portfolio);
        }

        // GET: Portfolio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio.FindAsync(id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // POST: Portfolio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PortfolioId,PortfolioName,UserId")] Portfolio portfolio)
        {
            if (id != portfolio.PortfolioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (String.IsNullOrEmpty(portfolio.UserId))
                    {
                        ApplicationUser applicationUser = await userManager.GetUserAsync(User);
                        portfolio.UserId = applicationUser.Id;
                    }

                    _context.Update(portfolio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PortfolioExists(portfolio.PortfolioId))
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
            return View(portfolio);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePortfolio(string id)
        {
            var port = await _context.Portfolio.FindAsync(Convert.ToInt32(id));

            string deleted = "";
            string msg = "";

            if (port == null)
            {
                msg = $"Portfolio with Id = {id} was not found";
                deleted = "false";
            }
            else
            {
                try
                {
                    _context.Portfolio.Remove(port);
                    _context.SaveChanges();
                    msg = "Portfolio successfully deleted";
                    deleted = "true";
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    msg = "User cannot be deleted";
                    deleted = "false";
                }
            }

            return Json(new { success = true, deleted, msg });
        }

        // GET: Portfolio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio
                .FirstOrDefaultAsync(m => m.PortfolioId == id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // POST: Portfolio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var portfolio = await _context.Portfolio.FindAsync(id);
            _context.Portfolio.Remove(portfolio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PortfolioExists(int id)
        {
            return _context.Portfolio.Any(e => e.PortfolioId == id);
        }
    }
}
