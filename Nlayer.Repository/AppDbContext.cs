using Microsoft.EntityFrameworkCore;
using Nlayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)   
        {
                
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<ProductFeature>().HasData(
                
                
                new ProductFeature() { 
                    Id=1,
                    Color="Kırmızı",
                    Height=200,
                    ProductId=1,
                    Width=100
                
                
                },
                new ProductFeature() { 
                    Id=2,
                    Color="Siyah",
                    Height=200,
                    ProductId=2,
                    Width=10
               
                
                } ,
                new ProductFeature() { 
                    Id=3,
                    Color="Beyaz",
                    Height=200,
                    ProductId=3,
                    Width=100
                
                
                },
                new ProductFeature() { 
                    Id=4,
                    Color="Mor",
                    Height=200,
                    ProductId=4,
                    Width=100
                
                
                },
                new ProductFeature() { 
                    Id=5,
                    Color="Lacivert",
                    Height=200,
                    ProductId=5,
                    Width=100
                
                
                });


        }

    }
}
