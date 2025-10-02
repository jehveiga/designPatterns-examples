using DesignPatterns.Examples.Core.Enums;

namespace DesignPatterns.Examples.Application.Models;

public class OrderInputModel
{
    public CustomerInputModel Customer { get; set; }
    public List<OrderItemInputModel> Items { get; set; }
    public DeliveryAddressInputModel DeliveryAddress { get; set; }
    public PaymentAddressInputModel PaymentAddress { get; set; }
    public PaymentInfoInputModel PaymentInfo { get; set; }
    public bool? IsInternational { get; set; }
}

public class CustomerInputModel
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Document { get; set; }
}

public class OrderItemInputModel
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class DeliveryAddressInputModel
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
}

public class PaymentAddressInputModel
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
}

public class PaymentInfoInputModel
{
    public PaymentMethod PaymentMethod { get; set; }
    public string CardNumber { get; set; }
    public string FullName { get; set; }
    public string ExpirationDate { get; set; }
    public string Cvv { get; set; }
}