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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Material Escolar",
                },
                 new Category
                 {
                     CategoryId = 2,
                     Name = "Acessórios",
                 }
                );
             builder 
                .HasMany(g => g.Products)
                .WithOne(c => c.Category)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
