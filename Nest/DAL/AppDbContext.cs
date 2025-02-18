﻿using Microsoft.EntityFrameworkCore;
using Nest.Models;

namespace Nest.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Catagory>Categories { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<ProductImage>ProductImages { get; set; }
    }
}
