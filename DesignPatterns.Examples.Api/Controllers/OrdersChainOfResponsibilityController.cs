using DesignPatterns.API.Infrastructure.Behavioral.ChainOfResponsibility;
using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Customers;
using DesignPatterns.Examples.Infrastructure.Payments;
using DesignPatterns.Examples.Infrastructure.Products;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersChainOfResponsibilityController : ControllerBase
{
    [HttpPost("using-chain")]
    public IActionResult PostWithChain(
    OrderInputModel model,
    [FromServices] IProductRepository productRepository,
    [FromServices] IPaymentFraudCheckService fraudCheckService,
    [FromServices] ICustomerRepository customerRepository)
    {
        ValidateCustomerHandler validateCustomerHandler = new(customerRepository);
        ValidateStockHandler validateStockHandler = new(productRepository);
        CheckForFraudHandler checkForFraudHandler = new(fraudCheckService);

        _ = validateCustomerHandler
            .SetNext(validateStockHandler)
            .SetNext(checkForFraudHandler);

        bool success = validateCustomerHandler.Handle(model);

        if (!success)
            return BadRequest();

        return NoContent();
    }
}