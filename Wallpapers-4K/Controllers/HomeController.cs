using Abp.Domain.Uow;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallpapers_4K.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Wallpapers_4K.Controllers
{
    public class HomeController : Controller
    {



        private readonly WallpaperDbContext _context;
        private readonly IWebHostEnvironment _env;
      

        public HomeController(WallpaperDbContext context, IWebHostEnvironment env )
        {
            _context = context;
            _env = env;
        }

        // GET: Category
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            return View(await _context.wallpapers.ToListAsync());

        }

      
        // Contact view
        public IActionResult Contact()
        {
            return View();
        }
    }
}
