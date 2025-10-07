using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersStrategyController : ControllerBase
{
    [HttpPost("payment-using-strategy")]
    public IActionResult ProcessPaymentWithStrategy(
        [FromServices] IPaymentStrategyFactory strategyFactory,
        [FromServices] IPaymentContext context,
        OrderInputModel model)
    {
        IPaymentStrategy strategy = strategyFactory.GetStrategy(model.PaymentInfo.PaymentMethod);

        object result = context.SetStrategy(strategy).Process(model);

        return Ok(result);
    }
}