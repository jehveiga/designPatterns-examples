using DesignPatterns.Examples.Core.Enums;
using DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories.Deliveries;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;
using DesignPatterns.Examples.Infrastructure.Deliveries;

namespace DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories;

public class NationalOrderAbstractFactory : IOrderAbstractFactory
{
    private readonly NationalDeliveryService _nationalDeliveryService;
    private readonly IPaymentServiceFactory _paymentServiceFactory;

    public NationalOrderAbstractFactory(
        NationalDeliveryService nationalDeliveryService,
        IPaymentServiceFactory paymentServiceFactory)
    {
        _nationalDeliveryService = nationalDeliveryService;
        _paymentServiceFactory = paymentServiceFactory;
    }

    public IDeliveryService GetDeliveryService()
    {
        return _nationalDeliveryService;
    }

    public IPaymentService GetPaymentService(PaymentMethod method)
    {
        return _paymentServiceFactory.GetService(method);
    }

    IDeliveryService IOrderAbstractFactory.GetDeliveryService()
    {
        throw new NotImplementedException();
    }
}