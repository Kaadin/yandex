using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class PrivetController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(string name)
    {
        return Ok($"Привет {name}");
    }
}