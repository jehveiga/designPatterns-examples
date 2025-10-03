using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersAbstractFactoryController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(
        [FromServices] InternationalOrderAbstractFactory internationalOrderAbstractFactory,
        [FromServices] NationalOrderAbstractFactory nationalOrderAbstractFactory,
        OrderInputModel model
        )
    {
        IOrderAbstractFactory orderAbstractFactory;

        if (model.IsInternational != null && model.IsInternational.Value)
            orderAbstractFactory = internationalOrderAbstractFactory;
        else
            orderAbstractFactory = nationalOrderAbstractFactory;

        _ = orderAbstractFactory
            .GetPaymentService(model.PaymentInfo.PaymentMethod)
            .Process(model);

        orderAbstractFactory
            .GetDeliveryService()
            .Deliver(model);

        return NoContent();
    }
}