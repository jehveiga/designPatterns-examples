using DesignPatterns.Examples.Infrastructure.Behavioral.Iterator;
using DesignPatterns.Examples.Infrastructure.Customers;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersIteratorController : ControllerBase
{
    [HttpGet("report-notify-blocked-customers")]
    public IActionResult NotifyBlockedCustomerEmail([FromServices] ICustomerRepository repository)
    {
        List<Core.Entities.Customer> blockedCustomers = repository.GetBlockedCustomers();

        CustomersToNotifyQueryModel query = new(blockedCustomers, "LuisDev");

        foreach (KeyValuePair<string, string> customer in query)
        {
            Console.WriteLine($"Customer: {customer.Key}, Email: {customer.Value}");
        }

        Console.WriteLine($"Utilizando acesso direto: {query["Fulano 1"]}");

        return Ok();
    }
}