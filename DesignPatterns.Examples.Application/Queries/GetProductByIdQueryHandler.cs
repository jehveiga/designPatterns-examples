namespace DesignPatterns.Examples.Application.Queries;

public class GetProductByIdQueryHandler
{
    public Task<ProductDetailsViewModel> Handle(GetProductByIdQuery query)
    {
        return Task.FromResult(new ProductDetailsViewModel());
    }
}