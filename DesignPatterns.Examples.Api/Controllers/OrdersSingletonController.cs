using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Creational.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersSingletonController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(
    OrderInputModel model
    )
    {
        return Ok(BusinessHours.GetInstance());
    }
}