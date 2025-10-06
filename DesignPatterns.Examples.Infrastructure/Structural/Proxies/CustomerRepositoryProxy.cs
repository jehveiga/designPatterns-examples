using DesignPatterns.Examples.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;

namespace DesignPatterns.Examples.Infrastructure.Structural.Proxies;

public class CustomerRepositoryProxy(
    ICustomerRepository repository,
    IMemoryCache cache,
    IHttpContextAccessor httpContextAccessor) : ICustomerRepository
{
    public List<Customer>? GetBlockedCustomers()
    {
        HttpContext httpContext = httpContextAccessor.HttpContext;

        if (httpContext == null)
            return null;

        if (httpContext.Request.Headers["x-role"] != "admin")
            return null;

        List<Customer> blockedCustomers = cache.GetOrCreate("blocked-customers", c =>
        {
            return repository.GetBlockedCustomers();
        });

        return blockedCustomers;
    }
}