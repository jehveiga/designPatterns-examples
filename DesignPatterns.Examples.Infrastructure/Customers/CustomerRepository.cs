using DesignPatterns.Examples.Core.Entities;

namespace DesignPatterns.Examples.Infrastructure.Customers;

public class CustomerRepository : ICustomerRepository
{
    public List<Customer> GetBlockedCustomers()
    {
        return
            [
                new Customer("Fulano 1", DateTime.Now.AddYears(-20), "luis1@mail.com"),
                new Customer("Fulano 2", DateTime.Now.AddYears(-30), "luis2@mail.com"),
                new Customer("Fulano 3", DateTime.Now.AddYears(-40), "luis3@mail.com")
            ];
    }

    public Customer GetCustomerById(Guid id)
    {
        return new Customer("Luis", DateTime.Now.AddYears(-30), "luis@mail.com");
    }
}