using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Wallpapers_4K.Models
{
    public class Wallpaper
    {
        public string Name { get; set; }
        public IFormFile Upload_Image { get; set; }

        public ICollection<Categories> Category { get; set; }

    }
}
