using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLiteExamples.Data;
using SQLiteExamples.Entities;
using SQLiteExamples.Services;

namespace SQLiteExamples.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;
    private readonly MyUrlService _myUrlService;
    private readonly RequestCounterService _requestCounterService;

    public ProductsController(ApplicationDbContext dbContext, MyUrlService myUrlService, RequestCounterService requestCounterService)
    {
        _dbContext = dbContext;
        _myUrlService = myUrlService;
        _requestCounterService = requestCounterService;

        _dbContext.Database.EnsureCreated();
    }
    
    [HttpPut("{id}")]
    public IActionResult Update(string id, Product product)
    {
        var productToUpdate = _dbContext
            .Products
            .FirstOrDefault(x => x.Id == id);
        
        if (productToUpdate is null)
            return NotFound();

        productToUpdate.Colour = product.Colour;
        productToUpdate.Name = product.Name;
        productToUpdate.Price = product.Price;
        productToUpdate.Size = product.Size;
        
        _dbContext.SaveChanges();
        
        _requestCounterService.Increment();
        
        return Ok("Urun basariyla guncellendi.");
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var product = _dbContext
            .Products
            .AsNoTracking()
            .FirstOrDefault(x => x.Id == id);
        
        if (product is null)
            return NotFound();
        
        _requestCounterService.Increment();
        
        return Ok(product);
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        var product = _dbContext
            .Products
            .FirstOrDefault(x => x.Id == id);
        
        if (product is null)
            return NotFound();
        
        _dbContext.Products.Remove(product);
        
        _dbContext.SaveChanges();
        
        _requestCounterService.Increment();
        
        return Ok("Urun basariyla silindi.");
    }
    
    
    [HttpPost]
    public IActionResult Create(Product product)
    {
        var url = _myUrlService.Url;
        _dbContext.Products.Add(product);
        
        _dbContext.SaveChanges();
        
        _requestCounterService.Increment();
        
        return Ok("Urun basariyla eklendi.");
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        var url = _myUrlService.Url;
        var products = _dbContext
            .Products
            .AsNoTracking()
            .Where(x=>x.Price>=100)
            .ToList();
        
        _requestCounterService.Increment();
        
        return Ok(products);
    }
    
}