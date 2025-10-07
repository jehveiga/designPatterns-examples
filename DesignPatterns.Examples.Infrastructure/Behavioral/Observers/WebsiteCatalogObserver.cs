namespace DesignPatterns.Examples.Infrastructure.Behavioral.Observers;

public class WebsiteCatalogObserver : IDealsObserver
{
    public void Update(IDealsSubject subject)
    {
        Console.WriteLine("Website Catalog has been updated with the following deals:");
    }
}