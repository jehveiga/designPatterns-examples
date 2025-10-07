using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;

public class PaymentContext : IPaymentContext
{
    private IPaymentStrategy? _strategy;

    public object Process(OrderInputModel model)
    {
        if (_strategy == null)
            throw new InvalidOperationException("Payment strategy not set.");

        object result = _strategy.Process(model);

        return result;
    }

    public IPaymentContext SetStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;

        return this;
    }
}