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
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        ///
      
        [HttpGet]
        public IActionResult login()
        {
            return View();
        }


        void connectionString()
        {
            con.ConnectionString = "data source=DESKTOP-4LK7J5A; database=wallpapers; integrated security=SSPI;";
        }

        [HttpPost]
        public IActionResult Verify(Admin user)
        {

            connectionString();
            con.Open();
            
            com.Connection = con;
            com.CommandText = "select * from tbl.admin where name='"+user.Name+"' and password='"+user.Password+"'";
            dr = com.ExecuteReader();

            if(dr.Read())
            {
                con.Close();

                return View("Create");
            }
            else
            {
                con.Close();

                return View("Error");
            }

            
        }
    }
}
