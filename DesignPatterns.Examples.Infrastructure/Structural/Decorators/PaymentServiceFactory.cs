using DesignPatterns.Examples.Core.Enums;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;
using DesignPatterns.Examples.Infrastructure.Structural.Facades;

namespace DesignPatterns.Examples.Infrastructure.Structural.Decorators;

public class PaymentServiceFactory(
    CreditCardService creditCardService,
    PaymentSlipService paymentSlipService,
    ICoreCrmIntegrationService crmService,
    IAntiFraudFacade antiFraudFacade
        ) : IPaymentServiceFactory
{
    public IPaymentService GetService(PaymentMethod paymentMethod)
    {
        IPaymentService paymentService;

        switch (paymentMethod)
        {
            case PaymentMethod.CreditCard:
                paymentService = creditCardService;

                break;

            case PaymentMethod.PaymentSlip:
                paymentService = paymentSlipService;

                break;

            default:
                throw new InvalidOperationException();
        }

        return new PaymentServiceDecorator(paymentService, crmService, antiFraudFacade);
    }
}