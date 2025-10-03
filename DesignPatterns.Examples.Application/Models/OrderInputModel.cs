using DesignPatterns.Examples.Core.Enums;

namespace DesignPatterns.Examples.Application.Models;

public class OrderInputModel
{
    public required CustomerInputModel Customer { get; set; }
    public required List<OrderItemInputModel> Items { get; set; }
    public required DeliveryAddressInputModel DeliveryAddress { get; set; }
    public required PaymentAddressInputModel PaymentAddress { get; set; }
    public required PaymentInfoInputModel PaymentInfo { get; set; }
    public bool? IsInternational { get; set; }
}

public class CustomerInputModel : ICloneable
{
    public CustomerInputModel()
    {
        RandomName = $"{new Random().Next(1, 999)}";
    }

    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Document { get; set; }
    private string RandomName { get; set; }

    public object Clone()
    {
        // return new CustomerInputModel {
        //     Id = Id,
        //     FullName = FullName,
        //     Email = Email,
        //     Document = Document,
        //     RandomName = RandomName
        // };
        return MemberwiseClone();
    }

    public string ReturnDataAsString()
    {
        return $"{Id}, {FullName}, {RandomName}, {Email}, {Document}";
    }
}

public class OrderItemInputModel
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class DeliveryAddressInputModel
{
    public required string Street { get; set; }
    public required string Number { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
}

public class PaymentAddressInputModel
{
    public required string Street { get; set; }
    public required string Number { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
}

public class PaymentInfoInputModel
{
    public PaymentMethod PaymentMethod { get; set; }
    public required string CardNumber { get; set; }
    public required string FullName { get; set; }
    public required string ExpirationDate { get; set; }
    public required string Cvv { get; set; }
}