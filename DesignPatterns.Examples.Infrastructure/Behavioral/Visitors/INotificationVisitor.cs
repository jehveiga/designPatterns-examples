namespace DesignPatterns.Examples.Infrastructure.Behavioral.Visitors;

public interface INotificationVisitor
{
    void Visit(SmsMessage message);

    void Visit(EmailMessage message);
}