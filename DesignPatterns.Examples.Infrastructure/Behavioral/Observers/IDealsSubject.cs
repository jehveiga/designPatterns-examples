namespace DesignPatterns.Examples.Infrastructure.Behavioral.Observers;

public interface IDealsSubject
{
    void SetDeals(List<string> deals);

    void Attach(IDealsObserver observer);

    void Detach(IDealsObserver observer);

    void Notify();
}