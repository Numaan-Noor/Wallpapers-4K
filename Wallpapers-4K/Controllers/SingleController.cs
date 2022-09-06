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
    public class SingleController : Controller
    {

        private readonly WallpaperDbContext _context;
        private readonly IWebHostEnvironment _env;


        public SingleController(WallpaperDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }








        [HttpGet]
        public  async Task<IActionResult> Index(int id)
        {
            /*   List<Wallpaper> li = new List<Wallpaper>(Id);
               li = _context.wallpapers.ToList();
               return View(li);*/

            /* var item = _context.wallpapers.Where(s => s.Id == Id).ToList();
             return View();*/

            var std = _context.wallpapers.ToList();
                return View(std.Where(s => s.Id ==id)); 
            


        }
    }
}
