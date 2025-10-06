using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.API.Infrastructure.Behavioral.ChainOfResponsibility;

public interface IOrderHandler
{
    bool Handle(OrderInputModel model);

    IOrderHandler SetNext(IOrderHandler handler);
}