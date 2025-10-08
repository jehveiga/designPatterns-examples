using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.TemplatesMethod;

public abstract class WarehouseTemplateMethod(OrderInputModel model)
{
    private readonly Dictionary<Guid, int> _orderItems = [];

    public void ExtractOrderData(OrderInputModel model)
    {
        foreach (OrderItemInputModel item in model.Items)
        {
            _orderItems.Add(item.ProductId, item.Quantity);
        }
    }

    public abstract void SeparateStockQuantities();

    public abstract void Notify();
}