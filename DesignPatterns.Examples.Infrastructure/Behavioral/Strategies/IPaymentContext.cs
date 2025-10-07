using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;

public interface IPaymentContext
{
    object Process(OrderInputModel model);

    IPaymentContext SetStrategy(IPaymentStrategy strategy);
}