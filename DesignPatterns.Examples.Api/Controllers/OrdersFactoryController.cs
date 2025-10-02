using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Factories.Payments;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersFactoryController : ControllerBase
{
    private readonly IPaymentServiceFactory _paymentServiceFactory;

    public OrdersFactoryController(IPaymentServiceFactory paymentServiceFactory)
    {
        _paymentServiceFactory = paymentServiceFactory;
    }

    [HttpPost]
    public IActionResult Post(OrderInputModel model)
    {
        IPaymentService service = _paymentServiceFactory.GetService(model.PaymentInfo.PaymentMethod);

        _ = service.Process(model);

        return NoContent();
    }
}