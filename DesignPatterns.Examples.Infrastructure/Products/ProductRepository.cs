namespace DesignPatterns.Examples.Infrastructure.Products;

public class ProductRepository : IProductRepository
{
    public bool HasStock(Dictionary<Guid, int> items)
    {
        return true;
    }
}