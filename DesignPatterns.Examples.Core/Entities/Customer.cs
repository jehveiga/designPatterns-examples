namespace DesignPatterns.Examples.Core.Entities;

public class Customer
{
    public Customer(string fullName, DateTime birthDate)
    {
        FullName = fullName;
        BirthDate = birthDate;
    }

    public string FullName { get; private set; }
    public DateTime BirthDate { get; private set; }
}