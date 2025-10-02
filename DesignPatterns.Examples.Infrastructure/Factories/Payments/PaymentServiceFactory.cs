using DesignPatterns.Examples.Core.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Examples.Infrastructure.Factories.Payments;

public class PaymentServiceFactory : IPaymentServiceFactory
{
    private readonly IServiceProvider _provider;

    public PaymentServiceFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public IPaymentService GetService(PaymentMethod method)
    {
        return method switch
        {
            PaymentMethod.CreditCard => _provider.GetRequiredService<CreditCardService>(),
            PaymentMethod.PaymentSlip => _provider.GetRequiredService<PaymentSlipService>(),
            _ => throw new NotSupportedException()
        };
    }
}