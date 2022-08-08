using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Wallpapers_4K.Models
{
    public class WallpaperDbContext : DbContext
    {
        public WallpaperDbContext(DbContextOptions<WallpaperDbContext> options) : base(options)
        {

        }
        public DbSet<Wallpaper> wallpapers{get;set;}
        public DbSet<Categories> categories { get; set; }
        public DbSet<User> users { get; set; }
    }
}
