using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Wallpapers_4K.Models;

namespace Wallpapers_4K.Controllers
{
    public class WallpaperController : Controller
    {

        private readonly WallpaperDbContext _context;
        private readonly IWebHostEnvironment _env;

        public WallpaperController(WallpaperDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env= env;
        }

        // GET: Category
        public async Task<IActionResult> Index()
        {
            return View(await _context.wallpapers.ToListAsync());
        }



        // GET: Category/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Wallpaper());
            else
                return View(_context.wallpapers.Find(id));

        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name,Categories,Photo")] Wallpaper wallpaper)
        {

            if (ModelState.IsValid)
            {
                string wwwwRootPath = _env.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(wallpaper.Photo.FileName);
                string extension = Path.GetExtension(wallpaper.Photo.FileName);
                wallpaper.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwwRootPath + "/Image/", fileName);
                using (var filestream= new FileStream(path,FileMode.Create))
                {
                    await wallpaper.Photo.CopyToAsync(filestream);
                }

                    _context.Add(wallpaper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wallpaper);
        }



        // GET: Category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var wallpaper = await _context.wallpapers.FindAsync(id);

            //delete image from wwwroot/image
            var imagePath = Path.Combine(_env.WebRootPath, "Image", wallpaper.Image);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.wallpapers.Remove(wallpaper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
