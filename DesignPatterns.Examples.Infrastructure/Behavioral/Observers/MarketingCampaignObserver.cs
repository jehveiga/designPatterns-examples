namespace DesignPatterns.Examples.Infrastructure.Behavioral.Observers;

public class MarketingCampaignObserver : IDealsObserver
{
    public void Update(IDealsSubject subject)
    {
        Console.WriteLine("Marketing Campaign has been updated with the following deals:");
    }
}