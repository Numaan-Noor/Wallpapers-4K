﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wallpapers_4K.Models
{
    public class Admin
    {   [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<Categories> categories { get; set; }
        public ICollection<Wallpaper> wallpapers { get; set; }
    }
}
