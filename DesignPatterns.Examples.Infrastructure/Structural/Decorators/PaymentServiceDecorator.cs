using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;

namespace DesignPatterns.Examples.Infrastructure.Structural.Decorators;

public class PaymentServiceDecorator : IPaymentService
{
    private readonly IPaymentService _paymentService;
    private readonly ICoreCrmIntegrationService _crmService;

    public PaymentServiceDecorator(IPaymentService paymentService, ICoreCrmIntegrationService crmService)
    {
        _paymentService = paymentService;
        _crmService = crmService;
    }

    public object Process(OrderInputModel model)
    {
        object result = _paymentService.Process(model);

        _crmService.Sync(model);

        return result;
    }
}