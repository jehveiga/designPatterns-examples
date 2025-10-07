namespace DesignPatterns.Examples.Infrastructure.Behavioral.Observers;

public interface IDealsObserver
{
    void Update(IDealsSubject subject);
}