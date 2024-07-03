using ECommerceApp.Entities;

namespace ECommerceApp.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public static ProductDto FromProduct(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                CategoryId = product.CategoryId,
                CategoryName = product.Category.Name,
                CreatedOn = product.CreatedOn
            };
        }



        // ProductDto.FromProduct(product)
    }
}
