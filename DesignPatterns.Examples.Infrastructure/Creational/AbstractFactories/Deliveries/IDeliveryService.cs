using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Creational.AbstractFactories.Deliveries;

public interface IDeliveryService
{
    void Deliver(OrderInputModel model);
}