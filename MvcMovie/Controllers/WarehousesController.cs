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
    public class WarehousesController : Controller
    {
        private readonly MvcMovieContext _context;

        public WarehousesController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Products
        // GET: Movies
        public async Task<IActionResult> Index(string warehousew_location, string searchString)
        {
            IQueryable<string> w_locationQuery = from p in _context.Product
                                                 orderby p.p_location
                                                 select p.p_location;

            var products = from p in _context.Product
                           select p;

            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.p_name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(warehousew_location))
            {
                products = products.Where(x => x.p_location == warehousew_location);
            }
            var warehousew_locationVM = new WarehouseLocationViewModel
            {
                p_locations = new SelectList(await w_locationQuery.Distinct().ToListAsync()),
                Products = await products.ToListAsync()
            };

            return View(warehousew_locationVM);
        }


    }
}

