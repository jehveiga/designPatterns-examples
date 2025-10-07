using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Core.Entities.States;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderStateController : ControllerBase
{
    [HttpPost("state")]
    public IActionResult OrderState(OrderInputModel model)
    {
        List<Guid> items = model.Items.Select(i => i.ProductId).ToList();

        OrderStateContext context = new(new OrderStartedState(items));

        context.Handle(); // Order is in 'Started' state.

        context.Add(Guid.NewGuid()); // Item {item} added to the order.

        context.Handle(); // Order is in 'Preparing' state.
        context.Handle(); // Order is in 'On Way to Delivery' state.
        context.Handle(); // Order is in 'Completed' state.

        return NoContent();
    }
}