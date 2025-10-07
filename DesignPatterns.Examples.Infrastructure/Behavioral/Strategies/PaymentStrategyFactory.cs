using DesignPatterns.Examples.Core.Enums;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;

internal class PaymentStrategyFactory : IPaymentStrategyFactory
{
    private IPaymentStrategy? _strategy;

    public IPaymentStrategy GetStrategy(PaymentMethod paymentMethod)
    {
        if (paymentMethod == PaymentMethod.PaymentSlip)
            _strategy = new PaymentSlipStrategy();
        else if (paymentMethod == PaymentMethod.CreditCard)
            _strategy = new CreditCardStrategy();

        return _strategy ?? throw new InvalidOperationException("Not was defined strategy");
    }
}