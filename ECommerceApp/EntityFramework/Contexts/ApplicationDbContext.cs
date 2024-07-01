using ECommerceApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.EntityFramework.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
