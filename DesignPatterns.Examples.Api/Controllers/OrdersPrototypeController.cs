using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersPrototypeController : ControllerBase
{
    private readonly IPaymentServiceFactory _paymentServiceFactory;

    public OrdersPrototypeController(IPaymentServiceFactory paymentServiceFactory)
    {
        _paymentServiceFactory = paymentServiceFactory;
    }

    [HttpPost]
    public IActionResult Post(
        OrderInputModel model
        )
    {
        string customerData = model.Customer.ReturnDataAsString();

        object customerCopy = model.Customer.Clone();
        string customerCopyData = (customerCopy as CustomerInputModel).ReturnDataAsString();

        return Ok(new { customerData, customerCopyData });
    }
}