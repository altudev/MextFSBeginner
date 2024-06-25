using Microsoft.AspNetCore.Mvc;
using SQLiteExamples.Services;

namespace SQLiteExamples.Controllers;
[ApiController]
[Route("[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly MyUrlService _myUrlService;
    private readonly RequestCounterService _requestCounterService;

    public CategoriesController(MyUrlService myUrlService, RequestCounterService requestCounterService)
    {
        _myUrlService = myUrlService;
        _requestCounterService = requestCounterService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        _requestCounterService.Increment();
        
        return Ok(_myUrlService.Url);
    }
}