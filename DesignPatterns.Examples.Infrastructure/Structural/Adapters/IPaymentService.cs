using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Structural.Adapters;

public interface IPaymentService
{
    object Process(OrderInputModel model);
}