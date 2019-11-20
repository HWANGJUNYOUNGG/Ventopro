using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class SellsController : Controller
    {
        private readonly MvcMovieContext _context;

        public SellsController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Sells
        public async Task<IActionResult> Index(string searchString)
        {
            var sells = from p in _context.Sell
                           select p;
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                sells = sells.Where(s => s.p_name.Contains(searchString));
            }
            var mvcMovieContext = _context.Sell.Include(s => s.Product);
            return View(await mvcMovieContext.ToListAsync());
        }

        // GET: Sells/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sell = await _context.Sell
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.s_code == id);
            if (sell == null)
            {
                return NotFound();
            }

            return View(sell);
        }

        // GET: Sells/Create
        public IActionResult Create()
        {
            ViewData["p_name"] = new SelectList(_context.Product, "p_name", "p_name");
            return View();
        }

        // POST: Sells/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("s_code,p_name,SellDate,s_amount,Price,Rating")] Sell sell)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sell);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["p_name"] = new SelectList(_context.Product, "p_name", "p_name", sell.p_name);
            return View(sell);
        }

        // GET: Sells/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sell = await _context.Sell.FindAsync(id);
            if (sell == null)
            {
                return NotFound();
            }
            ViewData["p_name"] = new SelectList(_context.Product, "p_name", "p_name", sell.p_name);
            return View(sell);
        }

        // POST: Sells/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("s_code,p_name,SellDate,s_amount,Price,Rating")] Sell sell)
        {
            if (id != sell.s_code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sell);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SellExists(sell.s_code))
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
            ViewData["p_name"] = new SelectList(_context.Product, "p_name", "p_name", sell.p_name);
            return View(sell);
        }

        // GET: Sells/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sell = await _context.Sell
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.s_code == id);
            if (sell == null)
            {
                return NotFound();
            }

            return View(sell);
        }

        // POST: Sells/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sell = await _context.Sell.FindAsync(id);
            _context.Sell.Remove(sell);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SellExists(string id)
        {
            return _context.Sell.Any(e => e.s_code == id);
        }
    }
}
