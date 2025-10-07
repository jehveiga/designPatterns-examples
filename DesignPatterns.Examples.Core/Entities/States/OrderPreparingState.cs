namespace DesignPatterns.Examples.Core.Entities.States;

internal class OrderPreparingState(List<Guid> items) : OrderStateBase(items), IOrderState
{
    public void Add(Guid item)
    {
        Items.Add(item);

        Console.WriteLine($"Item {item} added to the order.");
    }

    public void Handle()
    {
        Console.WriteLine("Order is in 'Preparing' state.");

        Context.SetCurrentState(new OrderOnWayToDeliveryState(Items));
    }
}