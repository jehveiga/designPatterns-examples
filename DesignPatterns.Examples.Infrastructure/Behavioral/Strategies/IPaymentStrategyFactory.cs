using DesignPatterns.Examples.Core.Enums;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;

public interface IPaymentStrategyFactory
{
    IPaymentStrategy GetStrategy(PaymentMethod paymentMethod);
}