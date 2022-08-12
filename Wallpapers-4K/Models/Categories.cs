using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wallpapers_4K.Models
{
    public class Categories
    {    [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("admin")]
        public int? AdminId { get; set; }
        public Admin admin { get; set; }
        [ForeignKey("wallpaper")]
        public int? WallpaperId { get; set; }
        public Wallpaper Wallpaper { get; set; }

    }
}
