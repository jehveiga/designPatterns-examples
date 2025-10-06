using DesignPatterns.Examples.Core.Entities;

namespace DesignPatterns.Examples.Infrastructure.Structural.Proxies;

public interface ICustomerRepository
{
    List<Customer> GetBlockedCustomers();
}