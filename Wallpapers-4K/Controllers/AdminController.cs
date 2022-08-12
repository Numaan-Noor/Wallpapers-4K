using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallpapers_4K.Models;
using System.Data.SqlClient;

namespace Wallpapers_4K.Controllers
{
    public class AdminController : Controller
    {
        ///
      
        [HttpGet]
        public IActionResult login()
        {
            return View();
        }




    }
}
