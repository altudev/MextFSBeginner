using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SQLiteExamples.Services;

namespace SQLiteExamples.Controllers;
[ApiController]
[Route("[controller]")]
public class RequestCountersController : ControllerBase
{
    private readonly RequestCounterService _requestCounterService;

    public RequestCountersController(RequestCounterService requestCounterService)
    {
        _requestCounterService = requestCounterService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var count = _requestCounterService.Get();

        return Ok(count);
    }
}