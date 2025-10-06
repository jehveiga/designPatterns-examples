using DesignPatterns.Examples.Infrastructure.Structural.Proxies;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersProxyController : ControllerBase
{
    [HttpGet("get-blocked-customers")]
    public IActionResult GetBlockedCustomers([FromServices] CustomerRepositoryProxy proxy)
    {
        List<Core.Entities.Customer>? blockedCustomers = proxy.GetBlockedCustomers();

        if (blockedCustomers == null)
            return Unauthorized();

        return Ok(blockedCustomers);
    }
}