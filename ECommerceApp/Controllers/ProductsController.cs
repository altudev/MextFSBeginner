using ECommerceApp.Dtos;
using ECommerceApp.Entities;
using ECommerceApp.EntityFramework.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var product = _context
                .Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

            if (product is null)
                return NotFound();

            var productDto = ProductDto.FromProduct(product);

            return Ok(productDto);
        }

        [HttpGet("GetByCategoryId/{categoryId:guid}")]
        public IActionResult GetByCategoryId(Guid categoryId)
        {
            var products = _context
                .Products
                 .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Category)
                .Select(product => ProductDto.FromProduct(product))
                .ToList();

            return Ok(products);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context
                .Products
                .Include(p => p.Category)
                .Select(product => ProductDto.FromProduct(product))
                .ToList();

            return Ok(products);
        }

        [HttpPut("{id:guid}")]
        public IActionResult Update(Guid id,ProductUpdateDto productUpdateDto)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product is null || product.Id != id)
                return BadRequest();

            product.Name = productUpdateDto.Name;
            product.Description = productUpdateDto.Description;
            product.Price = productUpdateDto.Price;
            product.Stock = productUpdateDto.Stock;
            product.CategoryId = productUpdateDto.CategoryId;
            product.ModifiedOn = DateTimeOffset.UtcNow;

            _context.SaveChanges();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateDto productCreateDto)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = productCreateDto.Name,
                Description = productCreateDto.Description,
                Price = productCreateDto.Price,
                Stock = productCreateDto.Stock,
                CategoryId = productCreateDto.CategoryId,
                CreatedOn = DateTimeOffset.UtcNow
            };

            _context.Products.Add(product);

            _context.SaveChanges();

            return Ok(product);
        }
    }
}
