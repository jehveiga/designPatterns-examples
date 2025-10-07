namespace DesignPatterns.Examples.Core.Entities.States;

internal class OrderOnWayToDeliveryState(List<Guid> items) : OrderStateBase(items), IOrderState
{
    public void Add(Guid item)
    {
        throw new InvalidOperationException("Cannot add items when the order is on the way to delivery.");
    }

    public void Handle()
    {
        Console.WriteLine("Order is in 'On Way to Delivery' state.");
    }
}