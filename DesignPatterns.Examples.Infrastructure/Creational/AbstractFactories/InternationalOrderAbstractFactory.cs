using DesignPatterns.Examples.Core.Enums;
using DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories.Deliveries;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;

namespace DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories;

public class InternationalOrderAbstractFactory : IOrderAbstractFactory
{
    public readonly IPaymentService _paymentService;
    public readonly IDeliveryService _deliveryService;

    public InternationalOrderAbstractFactory(
        CreditCardService creditCardService,
        InternationalDeliveryService internationalDeliveryService)
    {
        _paymentService = creditCardService;
        _deliveryService = internationalDeliveryService;
    }

    public IDeliveryService GetDeliveryService()
    {
        return _deliveryService;
    }

    public IPaymentService GetPaymentService(PaymentMethod method)
    {
        return _paymentService;
    }
}