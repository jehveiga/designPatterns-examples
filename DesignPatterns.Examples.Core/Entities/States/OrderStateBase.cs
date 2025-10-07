namespace DesignPatterns.Examples.Core.Entities.States;

public abstract class OrderStateBase(List<Guid> items)
{
    public List<Guid> Items { get; set; } = items;
    public OrderStateContext? Context { get; protected set; }

    public void SetContext(OrderStateContext context)
    {
        Context = context;
    }
}