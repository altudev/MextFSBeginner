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
    private static List<Product> _products = new List<Product>();

    public ProductsController(ApplicationDbContext dbContext, MyUrlService myUrlService, RequestCounterService requestCounterService)
    {
        _dbContext = dbContext;
        _myUrlService = myUrlService;
        _requestCounterService = requestCounterService;

        _dbContext.Database.EnsureCreated();

        _products = _dbContext.Products.ToList();
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
    
    [HttpPost("DeleteRange")]
    public IActionResult DeleteRange(List<string> ids)
    {
        // // LINQ
        // var products = _dbContext
        //     .Products
        //     .Where(x => ids.Contains(x.Id))
        //     .ToList();
        
        List<Product> products = new List<Product>();

        foreach (var id in ids)
        {
            var product = _dbContext
                .Products
                .FirstOrDefault(x => x.Id == id);
            
            products.Add(product);
        }
        
        _dbContext.Products.RemoveRange(products);
        
        _dbContext.SaveChanges();
        
        _requestCounterService.Increment();
        
        return Ok("Urunler basariyla silindi.");
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
    
    [HttpPost("CreateRange")]
    public IActionResult CreateRange(List<Product> products)
    {
        _dbContext.Products.AddRange(products);
        
        _dbContext.SaveChanges();
        
        _requestCounterService.Increment();
        
        return Ok("Urunler basariyla eklendi.");
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        // LINQ
        var products = _dbContext
            .Products
            .AsNoTracking()
            .ToList();
        
        _requestCounterService.Increment();
        
        return Ok(products);
    }
    
    [HttpGet("OrderByExample")]
    public IActionResult OrderByExample(bool isAscending)
    {
        // LINQ
        List<Product> products = _dbContext
            .Products
            .AsNoTracking()
            .ToList();

        if (isAscending)
        {
            products = products
                .OrderBy(p => p.Name,StringComparer.OrdinalIgnoreCase)
                .ToList();
        }
        else
        {
            products = products
                .OrderByDescending(p => p.Name,StringComparer.OrdinalIgnoreCase)
                .ToList();
        }
        
        _requestCounterService.Increment();
        
        return Ok(products);
    }
    
    [HttpGet("WhereOnPrice")]
    public IActionResult WhereOnPrice(decimal lowestPrice,decimal highestPrice)
    {
        // LINQ
        List<Product> products = _dbContext
            .Products
            .AsNoTracking()
            .Where(p => p.Price >= lowestPrice && p.Price <= highestPrice)
            .ToList();
        
        _requestCounterService.Increment();
        
        return Ok(products);
    }
    
    [HttpGet("SearchExampleWithContaints")]
    public IActionResult SearchExampleWithContaints(string searchParam)
    {
        // LINQ
        List<Product> products = _dbContext
            .Products
            .AsNoTracking()
            .ToList();

        products = products
            .Where(p => p.Name.ToLowerInvariant().Contains(searchParam.ToLowerInvariant()))
            .ToList();
        
        _requestCounterService.Increment();
        
        return Ok(products);
    }
    
}