using DesignPatterns.Examples.Core.Enums;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;

namespace DesignPatterns.Examples.Infrastructure.Structural.Decorators;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(PaymentMethod paymentMethod);
}