using DesignPatterns.Examples.Infrastructure.Factories.Payments;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Examples.Infrastructure;

public static class DependencyInjectionFactory
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        _ = services.AddFactories()
                    .AddServices();

        return services;
    }

    private static IServiceCollection AddFactories(this IServiceCollection services)
    {
        _ = services.AddScoped<IPaymentServiceFactory, PaymentServiceFactory>();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        _ = services.AddScoped<CreditCardService>();
        _ = services.AddScoped<PaymentSlipService>();
        // Do NOT register IPaymentService directly here

        return services;
    }
}