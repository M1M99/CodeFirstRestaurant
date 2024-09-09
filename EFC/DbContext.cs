using EFC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC
{
    internal class DbContext1 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NB7MT4D\\SQLEXPRESS;Initial Catalog=Rest;Integrated Security=True;Trust Server Certificate=True;");
        }
        public DbSet<Rating>Ratings{get; set;}
        public DbSet<Restourant> Restourant{get; set;}
        public DbSet<FavoriteRestaurant> RestourantUser{get; set;}
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories1{get; set;}
        public DbSet<User>Users{get; set;}
        public DbSet<FoodProd> MyProperty { get; set; }
        public DbSet<Dish> Foods { get; set; }
        public DbSet<MediaMenu> MediaMenu { get; set; }
        public DbSet<MediaRes> MediaRes { get; set; }
        public DbSet<MediaUser> MediaUser { get; set; }
    }
}
