using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VShop.ProductApi.Models;

namespace VShop.ProductInfrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder

                .HasKey(c => c.Id);

            builder

               .Property(c => c.Price)
               .HasPrecision(12, 2);

            builder

               .Property(c => c.Name)
               .HasMaxLength(255)
               .IsRequired();

            builder
                .Property(c => c.ImageURL)
                .HasMaxLength(255)
                .IsRequired();



        }
    }
}
