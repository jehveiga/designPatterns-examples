using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Customers;

namespace DesignPatterns.API.Infrastructure.Behavioral.ChainOfResponsibility;

public class ValidateCustomerHandler : OrderHandlerBase, IOrderHandler
{
    private readonly ICustomerRepository _repository;

    public ValidateCustomerHandler(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public override bool Handle(OrderInputModel model)
    {
        Console.WriteLine($"Invoking ValidateCustomerHandler.Handle");

        Examples.Core.Entities.Customer customer = _repository.GetCustomerById(model.Customer.Id);
        bool customerAllowedToBuy = customer.IsAllowedToBuy();

        if (!customerAllowedToBuy)
            return false;

        return base.Handle(model);
    }
}