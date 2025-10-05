namespace DesignPatterns.Examples.Infrastructure.Structural.Facades;
public record AntiFraudResultModel
{
    public bool CheckResult { get; set; }
    public required string Comments { get; set; }
}