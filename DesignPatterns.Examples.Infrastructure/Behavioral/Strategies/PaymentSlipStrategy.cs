using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;

public class PaymentSlipStrategy : IPaymentStrategy
{
    public object Process(OrderInputModel order)
    {
        return "Transaction processed using Payment Slip.";
    }
}