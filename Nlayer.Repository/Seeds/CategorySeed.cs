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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category { Id = 1, Name = "Kalemler" },
            new Category { Id = 2, Name = "Silgiler" },
            new Category { Id = 3, Name = "Suluklar" },
            new Category { Id = 4, Name = "Çantalar" },
            new Category { Id = 5, Name = "Defterler" }



            );
        }
    }
}
