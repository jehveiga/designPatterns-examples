using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Payments;

namespace DesignPatterns.API.Infrastructure.Behavioral.ChainOfResponsibility;

public class CheckForFraudHandler : OrderHandlerBase, IOrderHandler
{
    private readonly IPaymentFraudCheckService _paymentFraudCheckService;

    public CheckForFraudHandler(IPaymentFraudCheckService paymentFraudCheckService)
    {
        _paymentFraudCheckService = paymentFraudCheckService;
    }

    public override bool Handle(OrderInputModel model)
    {
        Console.WriteLine($"Invoking CheckForFraudHandler.Handle");

        bool isFraud = _paymentFraudCheckService.IsFraud(model);

        if (isFraud)
            return false;

        return base.Handle(model);
    }
}