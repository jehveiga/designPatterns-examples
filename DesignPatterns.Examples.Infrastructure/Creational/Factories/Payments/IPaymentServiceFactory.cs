using DesignPatterns.Examples.Core.Enums;

namespace DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(PaymentMethod paymentMethod);
}