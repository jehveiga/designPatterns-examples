namespace DesignPatterns.Examples.Core.Entities.States;

public class OrderCompletedState(List<Guid> items) : OrderStateBase(items), IOrderState
{
    public void Add(Guid item)
    {
        throw new InvalidOperationException("Cannot add items to a completed order.");
    }

    public void Handle()
    {
        Console.WriteLine("Order is in 'Completed' state.");
    }
}