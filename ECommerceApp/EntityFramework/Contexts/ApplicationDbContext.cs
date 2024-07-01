using ECommerceApp.Entities;
using ECommerceApp.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.EntityFramework.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ECommerceAppTunga;User Id=alper;Password=123alper123;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
