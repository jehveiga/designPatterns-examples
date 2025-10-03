using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Creational.Builders;

public interface IPaymentService
{
    object Process(OrderInputModel model);
}