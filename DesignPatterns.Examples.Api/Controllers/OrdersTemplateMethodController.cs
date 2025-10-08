using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Behavioral.TemplatesMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersTemplateMethodController : ControllerBase
{
    [HttpPost("template-method")]
    public IActionResult OrderTemplate(OrderInputModel model)
    {
        WarehouseTemplateMethod templateMethod;

        if (model.IsExternal)
        {
            templateMethod = new WarehouseExternalService(model);
        }
        else
        {
            templateMethod = new WarehouseInternalService(model);
        }

        templateMethod.ExtractOrderData(model);
        templateMethod.SeparateStockQuantities();
        templateMethod.Notify();

        return NoContent();
    }
}