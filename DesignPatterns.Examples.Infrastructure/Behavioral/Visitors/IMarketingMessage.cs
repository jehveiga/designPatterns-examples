namespace DesignPatterns.Examples.Infrastructure.Behavioral.Visitors;

public interface IMarketingMessage
{
    void Accept(NotificationVisitor visitor);

    string From { get; }
    string To { get; }
    string Content { get; }
}