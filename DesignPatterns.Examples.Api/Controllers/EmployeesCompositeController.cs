using DesignPatterns.Examples.Core.Entities;
using DesignPatterns.Examples.Infrastructure.Structural.Composites;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Examples.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesCompositeController : ControllerBase
{
    [HttpGet("get-expenses")]
    public IActionResult GetExpenses()
    {
        ManagerComposite composite = new("LuisDev", "Diretor", 100000);

        composite.Add(new Employee("Funcionário 1", "Analista", 300));
        composite.Add(new Employee("Funcionário 2", "Analista", 300));

        ManagerComposite composite2 = new("LuisDev Gerente", "Gerente", 15000);

        composite.Add(composite2);

        composite2.Add(new Employee("Funcionário 3", "Analista", 300));
        composite2.Add(new Employee("Funcionário 4", "Analista", 300));

        return Ok(new
        {
            expensesDirector = composite.GetExpenses(),
            expensesManager = composite2.GetExpenses()
        });
    }
}