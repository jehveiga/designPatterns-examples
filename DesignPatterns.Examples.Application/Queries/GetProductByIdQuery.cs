namespace DesignPatterns.Examples.Application.Queries;

public class GetProductByIdQuery : IQuery
{
    public GetProductByIdQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; private set; }
}