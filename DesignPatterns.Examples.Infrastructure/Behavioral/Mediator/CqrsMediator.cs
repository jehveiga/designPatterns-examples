using DesignPatterns.Examples.Application.Queries;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Mediator;

public interface ICqrsMediator
{
    Task<IMediatorResult> Handle(IQuery query);

    Task<IMediatorResult> Handle(ICommand command);
}

public class CqrsMediator : ICqrsMediator
{
    public async Task<IMediatorResult> Handle(IQuery query)
    {
        IMediatorResult mediatorResult;

        if (query is null)
            _ = new MediatorResult(null, false);

        if (query is GetProductByIdQuery)
        {
            GetProductByIdQueryHandler handler = new();

            ProductDetailsViewModel result = await handler.Handle(query as GetProductByIdQuery);

            mediatorResult = new MediatorResult(result, true);
        }
        else if (query is GetAllProductsQuery)
        {
            GetAllProductsQueryHandler handler = new();

            var result = await handler.Handle(query as GetAllProductsQuery);

            mediatorResult = new MediatorResult(result, true);
        }
        else
        {
            mediatorResult = new MediatorResult(null, false);
        }

        return mediatorResult;
    }

    public Task<IMediatorResult> Handle(ICommand command)
    {
        throw new NotImplementedException();
    }
}

public interface ICommand
{ }

public interface IMediatorResult
{
    object Data { get; }
    bool Success { get; }
}

public class MediatorResult : IMediatorResult
{
    public MediatorResult(object data, bool success)
    {
        Data = data;
        Success = success;
    }

    public object Data { get; private set; }
    public bool Success { get; private set; }
}