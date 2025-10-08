using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.TemplatesMethod;

public class WarehouseInternalService(OrderInputModel model) : WarehouseTemplateMethod(model)
{
    public override void Notify()
    {
        Console.WriteLine("Notifying internal warehouse system...");
    }

    public override void SeparateStockQuantities()
    {
        Console.WriteLine("Separating stock quantities in internal warehouse system...");
    }
}