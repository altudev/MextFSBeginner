using ECommerceApp.Dtos;
using ECommerceApp.Entities;
using ECommerceApp.EntityFramework.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _context
                .Categories
                .ToList();

            return Ok(categories);
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateDto categoryCreateDto)
        {
            var category = new Category()
            {
                Id = Guid.NewGuid(),
                Name = categoryCreateDto.Name,
                Description = categoryCreateDto.Description,
                CreatedOn = DateTimeOffset.UtcNow
            };

            _context.Categories.Add(category);

            _context.SaveChanges();

            return Ok(category);
        }
    }
}
