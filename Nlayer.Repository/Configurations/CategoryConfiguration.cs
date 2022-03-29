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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id); //ID (primary )si belli ama yinede ben belirtiyorum..

            builder.Property(x => x.Id).UseIdentityColumn(); //Otamtik olarak varsayılan olarak 1 er 1 er ıd artısın .

            builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);

            builder.ToTable("Categories");


        }
    }
}
