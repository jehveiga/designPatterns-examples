using DesignPatterns.Examples.Core.Enums;
using DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories.Deliveries;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;

namespace DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories;

public interface IOrderAbstractFactory
{
    IPaymentService GetPaymentService(PaymentMethod method);

    IDeliveryService GetDeliveryService();
}