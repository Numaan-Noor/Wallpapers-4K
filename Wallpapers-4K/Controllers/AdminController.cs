using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallpapers_4K.Models;
using System.Data.SqlClient;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace Wallpapers_4K.Controllers
{
    public class AdminController : Controller
    {
        
      
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Admin model)
        {
            string userName = model.Name;
            string password = model.Password;
            if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }

            //Check the user name and password  
            //Here can be implemented checking logic from the database  
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            if (userName == "wap" && password == "wap321#")
            {
                return RedirectToAction("Index", "dashboard");
            }
            else
            {
                Console.WriteLine("Password is not correct");
            }
            return View();
        }


        }
}
