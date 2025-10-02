using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Factories.Payments;

public interface IPaymentService
{
    object Process(OrderInputModel model);
}