namespace DesignPatterns.Examples.Infrastructure.Behavioral.Visitors;

public class SmsMessage(string from, string to, string content) : IMarketingMessage
{
    public string From { get; private set; } = from;

    public string To { get; private set; } = to;

    public string Content { get; private set; } = content;

    public void Accept(NotificationVisitor visitor)
    {
        visitor.Visit(this);
    }
}