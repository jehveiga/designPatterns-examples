namespace DesignPatterns.Examples.Application.Models;

public class FraudCheckModel(decimal totalAmount, Guid customerId, string customerName, string document)
{
    public decimal TotalAmount { get; private set; } = totalAmount;
    public Guid CustomerId { get; private set; } = customerId;
    public string CustomerName { get; private set; } = customerName;
    public string Document { get; private set; } = document;
}