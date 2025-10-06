using DesignPatterns.Examples.Core.Enums;
using DesignPatterns.Examples.Infrastructure.Structural.Flyweight;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentsFlyweightController : ControllerBase
{
    [HttpGet("payment-methods/{paymentMethod}")]
    public IActionResult GetPaymentMethodDetails(PaymentMethod paymentMethod,
        [FromServices] PaymentMethodsFactory factory)
    {
        if (paymentMethod == PaymentMethod.Unknown)
            return BadRequest();

        Application.Models.PaymentMethodViewModel model = factory.GetPaymentMethod(paymentMethod);

        return Ok(model);
    }
}