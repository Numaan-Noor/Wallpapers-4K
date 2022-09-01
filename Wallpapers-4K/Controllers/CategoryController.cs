using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallpapers_4K.Models;

namespace Wallpapers_4K.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {

        private readonly WallpaperDbContext _context;

        public CategoryController(WallpaperDbContext context)
        {
            _context = context;
        }

        // GET: Category
        public async Task<IActionResult> Index()
        {
            return View(await _context.categories.ToListAsync());
        }



        // GET: Category/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Categories());
            else
                return View(_context.categories.Find(id));

        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name")] Categories category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                    _context.Add(category);
                else
                    _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }



        // GET: Category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var category = await _context.categories.FindAsync(id);
            _context.categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}

