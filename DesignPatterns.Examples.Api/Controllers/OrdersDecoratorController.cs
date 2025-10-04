using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersDecoratorController : Controller
{
    private readonly IPaymentServiceFactory _paymentServiceFactory;

    public OrdersDecoratorController(
        IPaymentServiceFactory paymentServiceFactory)
    {
        _paymentServiceFactory = paymentServiceFactory;
    }

    [HttpPost("simpler")]
    public IActionResult SimplerPost(
        [FromServices] IPaymentServiceFactory paymentServiceFactory,
        OrderInputModel model
        )
    {
        IPaymentService paymentService = paymentServiceFactory.GetService(model.PaymentInfo.PaymentMethod);

        // Precisamos adicionar novos comportamentos ao "paymentService.Process", mas não
        // queremos alterar sua implementação
        _ = paymentService.Process(model);

        return NoContent();
    }

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