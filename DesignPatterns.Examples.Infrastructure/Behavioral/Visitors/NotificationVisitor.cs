namespace DesignPatterns.Examples.Infrastructure.Behavioral.Visitors;

public class NotificationVisitor : INotificationVisitor
{
    public void Visit(SmsMessage message)
    {
        Console.WriteLine($"Sending SMS to {message.To}: {message.Content}");
    }

    public void Visit(EmailMessage message)
    {
        Console.WriteLine($"Sending Email to {message.To}: {message.Content}");
    }
}