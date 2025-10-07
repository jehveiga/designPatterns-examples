namespace DesignPatterns.Examples.Infrastructure.Behavioral.Observers;

internal class DealsSubject : IDealsSubject
{
    private readonly List<IDealsObserver> _observers = [];
    public List<string> CurrentDeals { get; private set; } = [];

    public void Attach(IDealsObserver observer)
    {
        if (!_observers.Any(o => o.Equals(observer)))
            _observers.Add(observer);
    }

    public void Detach(IDealsObserver observer)
    {
        _ = _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IDealsObserver observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void SetDeals(List<string> deals)
    {
        CurrentDeals = deals;

        Notify();
    }
}