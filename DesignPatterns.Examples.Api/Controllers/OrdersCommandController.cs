using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Payments;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersCommandController : ControllerBase
{
    [HttpPost("using-command")]
    public IActionResult PostUsingCommand(
    OrderInputModel model,
    [FromServices] IPaymentFraudCheckService fraudCheckService)
    {
        decimal total = model.Items.Sum(i => i.Price * i.Quantity);
        FraudCheckModel command = new(total, model.Customer.Id, model.Customer.FullName, model.Customer.Document);

        bool isFraud = fraudCheckService.IsFraudV2UsingCommand(command);

        if (isFraud)
            return BadRequest();

        // Chamar um serviço de mensageria para enviar esse objeto como JSON
        // Guardar um log desse objeto

        return NoContent();
    }
}