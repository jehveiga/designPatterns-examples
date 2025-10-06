using DesignPatterns.Examples.Application.Models;
using DesignPatterns.Examples.Infrastructure.Products;

namespace DesignPatterns.API.Infrastructure.Behavioral.ChainOfResponsibility;

public class ValidateStockHandler : OrderHandlerBase, IOrderHandler
{
    private readonly IProductRepository _repository;

    public ValidateStockHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public override bool Handle(OrderInputModel model)
    {
        Console.WriteLine($"Invoking ValidateStockHandler.Handle");

        Dictionary<Guid, int> itemsDictionary = model.Items.ToDictionary(d => d.ProductId, d => d.Quantity);
        bool hasStock = _repository.HasStock(itemsDictionary);

        if (!hasStock)
            return false;

        return base.Handle(model);
    }
}