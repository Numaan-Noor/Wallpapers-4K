using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallpapers_4K.Models;

namespace Wallpapers_4K.Controllers
{
    public class GalleryController : Controller
    {
        private readonly WallpaperDbContext _context;
        private readonly IWebHostEnvironment _env;


        public GalleryController(WallpaperDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }








        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {

            var std = await _context.wallpapers.ToListAsync();
            return View(std.Where(s => s.CategoryId == id));
        }
      
    }
}
