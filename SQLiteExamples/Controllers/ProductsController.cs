using Microsoft.AspNetCore.Mvc;
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
            .Where(x=>x.Price>=100)
            .ToList();
        
        _requestCounterService.Increment();
        
        return Ok(products);
    }
    
}