using DesignPatterns.Examples.Infrastructure.Behavioral.Strategies;
using DesignPatterns.Examples.Infrastructure.Creational.Factories.Payments;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Examples.Infrastructure;

public static class DependencyInjectionFactory
{
    public static IServiceCollection AddInfrastructureFactory(this IServiceCollection services)
    {
        _ = services.AddFactories()
                    .AddServices()
                    .AddStrategies();

        return services;
    }

    private static IServiceCollection AddFactories(this IServiceCollection services)
    {
        _ = services.AddScoped<IPaymentServiceFactory, PaymentServiceFactory>();
        _ = services.AddScoped<IPaymentStrategyFactory, PaymentStrategyFactory>();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        _ = services.AddScoped<CreditCardService>();
        _ = services.AddScoped<PaymentSlipService>();
        // Do NOT register IPaymentService directly here

        return services;
    }

    private static IServiceCollection AddStrategies(this IServiceCollection services)
    {
        _ = services.AddScoped<IPaymentContext, PaymentContext>();

        return services;
    }
}