namespace DesignPatterns.Examples.Core.Entities.States;

public interface IOrderState
{
    void Handle();

    void Add(Guid item);

    void SetContext(OrderStateContext order);

    OrderStateContext Context { get; }
}