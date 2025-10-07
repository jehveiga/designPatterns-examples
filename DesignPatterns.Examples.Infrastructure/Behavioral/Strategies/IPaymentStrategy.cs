using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;

public interface IPaymentStrategy
{
    object Process(OrderInputModel order);
}