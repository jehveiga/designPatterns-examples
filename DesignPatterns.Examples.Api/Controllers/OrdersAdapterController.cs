using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

public class OrdersAdapterController : Controller
{
    private readonly IPaymentServiceFactory _paymentServiceFactory;

    public OrdersAdapterController(
        IPaymentServiceFactory paymentServiceFactory)
    {
        _paymentServiceFactory = paymentServiceFactory;
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