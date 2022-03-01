using DotnetMongoDBDemo.Models;
using Microsoft.AspNetCore.Mvc;
namespace DotnetMongoDBDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase {
    
    [HttpGet]
    public string Get() {
        return "Hello World!";
    }

    [HttpPost]
    public IActionResult Post([FromBody] Todo request) {
        if(string.IsNullOrEmpty(request.title)) {
            return NotFound();
        }
        return Ok(request);
    }
}
