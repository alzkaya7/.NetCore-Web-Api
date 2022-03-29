using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nlayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200); //isim kısmı zorunlu olsun ve max 200 karkater alsın ..

            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2"); //parasal değerim 18 karakter olsun tolplmada ama virüglden sonra  2 karakter olsun 16 öcensi  2 sornası yoplam 18 ..

            builder.Property(x => x.Stock).IsRequired();

            builder.ToTable(nameof(Product));

        }
    }
}
