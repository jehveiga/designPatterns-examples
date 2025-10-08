namespace DesignPatterns.Examples.Infrastructure.Behavioral.Visitors;

public class NotificationService
{
    public void Notify(List<IMarketingMessage> messages)
    {
        NotificationVisitor visitor = new();

        foreach (IMarketingMessage message in messages)
        {
            message.Accept(visitor);
        }
    }
}