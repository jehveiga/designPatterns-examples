using DesignPatterns.Examples.Application.Queries;
using DesignPatterns.Examples.Infrastructure.Behavioral.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsMediatorController(ICqrsMediator mediator) : ControllerBase
{
    [HttpGet("with-mediator")]
    public async Task<IActionResult> GetAllWithMediator()
    {
        GetAllProductsQuery query = new();

        IMediatorResult result = await mediator.Handle(query);

        return Ok(result);
    }

    [HttpGet("{id}/with-mediator")]
    public async Task<IActionResult> GetByIdWithMediator(Guid id)
    {
        GetProductByIdQuery query = new(id);

        IMediatorResult result = await mediator.Handle(query);

        return Ok(result);
    }
}