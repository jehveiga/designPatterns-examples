namespace DesignPatterns.Examples.Infrastructure.Behavioral.Visitors;

public class EmailMessage(string from, string to, string content, string subject) : IMarketingMessage
{
    public string From { get; private set; } = from;

    public string To { get; private set; } = to;

    public string Content { get; private set; } = content;

    public string Subject { get; private set; } = subject;

    public void Accept(NotificationVisitor visitor)
    {
        visitor.Visit(this);
    }
}