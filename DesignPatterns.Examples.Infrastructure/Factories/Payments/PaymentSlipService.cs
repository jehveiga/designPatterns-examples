using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Factories.Payments;

public class PaymentSlipService : IPaymentService
{
    public object Process(OrderInputModel model)
    {
        return "Dados do Boleto";
    }
}