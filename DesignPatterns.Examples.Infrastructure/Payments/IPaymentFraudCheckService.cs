using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Payments;

public interface IPaymentFraudCheckService
{
    bool IsFraud(OrderInputModel model);

    bool IsFraudV2(decimal totalAmount, Guid customerId, string customerName, string document);

    bool IsFraudV2UsingCommand(FraudCheckModel command);
}

public class PaymentFraudCheckService : IPaymentFraudCheckService
{
    public bool IsFraud(OrderInputModel model)
    {
        return false;
    }

    public bool IsFraudV2(decimal totalAmount, Guid customerId, string customerName, string document)
    {
        return false;
    }

    public bool IsFraudV2UsingCommand(FraudCheckModel command)
    {
        return false;
    }
}