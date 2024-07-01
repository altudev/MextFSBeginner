using ECommerceApp.Common;

namespace ECommerceApp.Entities
{
    public class Product:EntityBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Foreign key
        public Guid CategoryId { get; set; }
        // Navigation property
        public Category Category { get; set; }

        // ApplicationDbContext
        // .Products
        // .Include(p => p.Category)
        // .FirstOrDefault(p => p.Id == id);

        // product.Category.Name
    }
}
