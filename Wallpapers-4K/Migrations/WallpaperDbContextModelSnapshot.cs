﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wallpapers_4K.Models;

namespace Wallpapers_4K.Migrations
{
    [DbContext(typeof(WallpaperDbContext))]
    partial class WallpaperDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wallpapers_4K.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Wallpapers_4K.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WallpaperId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("WallpaperId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Wallpapers_4K.Models.Wallpaper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("wallpapers");
                });

            modelBuilder.Entity("Wallpapers_4K.Models.Categories", b =>
                {
                    b.HasOne("Wallpapers_4K.Models.Admin", "admin")
                        .WithMany("categories")
                        .HasForeignKey("AdminId");

                    b.HasOne("Wallpapers_4K.Models.Wallpaper", "Wallpaper")
                        .WithMany("Categories")
                        .HasForeignKey("WallpaperId");
                });

            modelBuilder.Entity("Wallpapers_4K.Models.Wallpaper", b =>
                {
                    b.HasOne("Wallpapers_4K.Models.Admin", "admin")
                        .WithMany("wallpapers")
                        .HasForeignKey("AdminId");
                });
#pragma warning restore 612, 618
        }
    }
}
