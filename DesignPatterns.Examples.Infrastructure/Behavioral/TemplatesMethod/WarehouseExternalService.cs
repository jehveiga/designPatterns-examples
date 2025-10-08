using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.TemplatesMethod;

public class WarehouseExternalService(OrderInputModel model) : WarehouseTemplateMethod(model)
{
    public override void Notify()
    {
        Console.WriteLine("Notifying external warehouse system...");
    }

    public override void SeparateStockQuantities()
    {
        Console.WriteLine("Separating stock quantities in external warehouse system...");
    }
}