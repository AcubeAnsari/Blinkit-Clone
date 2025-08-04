﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Temp.Data;
using Temp.Models;

namespace Temp.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products= await _context.Products.ToListAsync();
            return View(products);
        }



        [HttpGet]

        public IActionResult Create()
        {
            return View ();
        }


        [HttpPost]

        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
;
            }

            return RedirectToAction(nameof(Index));

        }




    }
}
