using DesignPatterns.Examples.Infrastructure.Behavioral.Observers;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsObserverController : ControllerBase
{
    [HttpGet("deals")]
    public IActionResult Deals([FromServices] IEnumerable<IDealsObserver> observers, [FromServices] IDealsSubject subject)
    {
        foreach (IDealsObserver observer in observers)
        {
            subject.Attach(observer);
        }

        subject.SetDeals(["50% off on all products!", "PS5 - R$ 5000"]);

        return NoContent();
    }
}