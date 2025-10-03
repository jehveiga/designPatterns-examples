using DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories;
using DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories.Deliveries;
using DesignPatterns.Examples.Infrastructure.Deliveries;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Examples.Infrastructure;

public static class DependencyInjectionAbstractFactory
{
    public static IServiceCollection AddInfrastructureAbstractFactory(this IServiceCollection services)
    {
        _ = services.AddFactories()
                    .AddServices();

        return services;
    }

    private static IServiceCollection AddFactories(this IServiceCollection services)
    {
        _ = services.AddScoped<InternationalOrderAbstractFactory>();
        _ = services.AddScoped<NationalOrderAbstractFactory>();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        _ = services.AddScoped<InternationalDeliveryService>();
        _ = services.AddScoped<NationalDeliveryService>();

        return services;
    }
}