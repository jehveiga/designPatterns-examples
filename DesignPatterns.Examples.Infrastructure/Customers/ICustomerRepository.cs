using DesignPatterns.Examples.Core.Entities;

namespace DesignPatterns.Examples.Infrastructure.Customers;

public interface ICustomerRepository
{
    List<Customer> GetBlockedCustomers();

    Customer GetCustomerById(Guid id);
}