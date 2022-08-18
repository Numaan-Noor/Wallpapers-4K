using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallpapers_4K.Controllers
{
    public class WallpaperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
