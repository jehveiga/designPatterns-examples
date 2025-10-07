using DesignPatterns.Examples.Core.Entities;
using System.Collections;

namespace DesignPatterns.Examples.Infrastructure.Behavioral.Iterator;

public class CustomersToNotifyQueryModel : IEnumerable<KeyValuePair<string, string>>
{
    public CustomersToNotifyQueryModel(List<Customer> customer, string generatedBy)
    {
        _customerAndEmailDict = customer.ToDictionary(c => c.FullName, c => c.Email);

        GeneratedAt = DateTime.Now;
        GeneratedBy = generatedBy;
    }

    public string this[string customerFullName]
    {
        get
        {
            if (_customerAndEmailDict.ContainsKey(customerFullName))
            {
                return _customerAndEmailDict[customerFullName];
            }

            return null;
        }
        set
        {
            _customerAndEmailDict[customerFullName] = value;
        }
    }

    private readonly Dictionary<string, string> _customerAndEmailDict;
    public DateTime GeneratedAt { get; private set; }
    public string GeneratedBy { get; private set; }

    public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
    {
        return _customerAndEmailDict.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}