namespace DesignPatterns.Examples.Core.Entities.States;

public class OrderStartedState(List<Guid> items) : OrderStateBase(items), IOrderState
{
    public void Add(Guid item)
    {
        Items.Add(item);

        Console.WriteLine($"Item {item} added to the order.");
    }

    public void Handle()
    {
        Console.WriteLine("Order is in 'Started' state.");

        Context.SetCurrentState(new OrderPreparingState(Items));
    }
}