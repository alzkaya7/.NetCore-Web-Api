using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nlayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
               
                Id = 1,
                CategoryId = 1,
                Name = "Kalem 1",
                Price = 100,
                Stock = 30,
                CreatedDate = DateTime.Now,



            },
            new Product
            {
                Id = 2,
                CategoryId = 2,
                Name = "Silgi 1",
                Price = 200,
                Stock = 40,
                CreatedDate = DateTime.Now



            },
            new Product
            {
                Id = 3,
                CategoryId = 3,
                Name = "Suluk 1",
                Price = 150,
                Stock = 20,
                CreatedDate = DateTime.Now



            },
            new Product
            {
                Id = 4,
                CategoryId = 4,
                Name = "Çanta 1",
                Price = 130,
                Stock = 10,
                CreatedDate = DateTime.Now



            },
            new Product
            {
                Id = 5,
                CategoryId = 5,
                Name = "Defter 1",
                Price = 140,
                Stock = 50,
                CreatedDate = DateTime.Now

            }

            );
        }
    }
}
