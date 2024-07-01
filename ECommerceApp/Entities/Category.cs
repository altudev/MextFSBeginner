using ECommerceApp.Common;

namespace ECommerceApp.Entities
{
    public class Category:EntityBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        // Navigation property
        public ICollection<Product> Products { get; set; }

        // ApplicationDbContext
        // .Categories
        // .Include(c => c.Products)
        // .FirstOrDefaultAsync(c => c.Id == categoryId);

        // foreach (var product in category.Products)
    }
}
