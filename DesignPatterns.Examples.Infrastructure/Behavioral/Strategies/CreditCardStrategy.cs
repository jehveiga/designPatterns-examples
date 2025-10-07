using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;

public class CreditCardStrategy : IPaymentStrategy
{
    public object Process(OrderInputModel order)
    {
        return "Transaction processed using Credit Card.";
    }
}