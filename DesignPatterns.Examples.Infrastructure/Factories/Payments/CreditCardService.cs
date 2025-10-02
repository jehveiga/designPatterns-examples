using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Factories.Payments;

public class CreditCardService : IPaymentService
{
    public object Process(OrderInputModel model)
    {
        return "Transação aprovada";
    }
}