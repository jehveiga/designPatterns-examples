using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Application.Queries;

public class GetAllProductsQueryHandler
{
    public Task<ProductViewModel> Handle(GetAllProductsQuery query)
    {
        return Task.FromResult(new ProductViewModel());
    }
}