namespace DesignPatterns.Examples.Core.Entities.States;

public class OrderStateContext
{
    private IOrderState _state;

    public OrderStateContext(IOrderState state)
    {
        SetCurrentState(state);
    }

    public void SetCurrentState(IOrderState state)
    {
        _state = state;
        _state.SetContext(this);
    }

    public void Handle()
    {
        _state.Handle();
    }

    public void Add(Guid item)
    {
        _state.Add(item);
    }
}