using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;
using DesignPatterns.Examples.Infrastructure.Structural.Facades;

namespace DesignPatterns.Examples.Infrastructure.Structural.Decorators;

public class PaymentServiceDecorator(
    IPaymentService paymentService,
    ICoreCrmIntegrationService crmService,
    IAntiFraudFacade antiFraudFacade) : IPaymentService
{
    public object Process(OrderInputModel model)
    {
        AntiFraudModel antiFraudModel = new(model.Customer.Document, model.TotalPrice);
        AntiFraudResultModel? antiFraudResult = antiFraudFacade.Check(antiFraudModel);

        if (antiFraudResult is null || antiFraudResult.CheckResult)
            throw new InvalidOperationException(antiFraudResult?.Comments);

        object result = paymentService.Process(model);

        crmService.Sync(model);

        return result;
    }
}