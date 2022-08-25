using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Wallpapers_4K.Models
{
    public class Wallpaper
    {    [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        [ForeignKey("admin")]
        public int? AdminId  { get; set; }
        public Admin admin { get; set; }
        public ICollection<Categories> Categories { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
