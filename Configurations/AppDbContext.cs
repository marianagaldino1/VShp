using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.Configurations;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // adiciona todas as referências que utilizam como extensão a IEntityTypeConfiguration 
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}