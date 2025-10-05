namespace DesignPatterns.Examples.Infrastructure.Structural.Facades;

public interface IAntiFraudFacade
{
    AntiFraudResultModel Check(AntiFraudModel model);
}