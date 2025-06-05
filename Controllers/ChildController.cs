using Microsoft.AspNetCore.Mvc;
using WebApplication2.models;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class ChildController(IChildService service) : ControllerBase
{
    private readonly IChildService _service = service;


    [HttpGet]
    public string Get()
    {
        return _service.GetGreeting();
    }
}
