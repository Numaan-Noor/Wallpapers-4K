using Abp.Domain.Uow;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Wallpapers_4K.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Wallpapers_4K.Controllers
{
    public class HomeController : Controller
    {

        private readonly WallpaperDbContext _context;
        private readonly IWebHostEnvironment _env;
        private CancellationToken catelist;

        public HomeController(WallpaperDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: Home
        public async Task<IActionResult> Index(int id)
        {


            return View(await _context.wallpapers.ToListAsync());
        }

        /*        [HttpGet]
                public async Task<IActionResult> _LayoutHome()
                {

                    *//*   List<Categories> li = new List<Categories>();
                       li = _context.categories.ToList();
                       ViewBag.listofitems = li;*//*
                    WallpaperDbContext dc = new WallpaperDbContext();
                    List <Categories> c= await dc.categories.ToListAsync();

                    dynamic dy = new ExpandoObject();
                    dy.cat = c;
                    return View (dy);
        */
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> GetItems()
        {
            return await _context.categories
                .Select(x => ItemToDTO(x))
                .ToListAsync();
        }

        private static Categories ItemToDTO(Categories categories) => new Categories
       {
           Id = categories.Id,
           Name = categories.Name
       };



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wallpaper>>> GetWallpaper()
        {
            return await _context.wallpapers
                .Select(x => Itemwall(x))
                .ToListAsync();
        }

        private static Wallpaper Itemwall(Wallpaper wallpaper) => new Wallpaper
        {
            Id = wallpaper.Id,
            Name = wallpaper.Name,
            Image = wallpaper.Image
        };

    }

        }

    


