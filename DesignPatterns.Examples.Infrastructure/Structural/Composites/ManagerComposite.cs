using DesignPatterns.Examples.Core.Entities;

namespace DesignPatterns.Examples.Infrastructure.Structural.Composites;

public class ManagerComposite : EmployeeComponent
{
    private readonly List<EmployeeComponent> _children;

    public ManagerComposite(string name, string role, decimal expenses) : base(name, role, expenses)
    {
        _children = [];
    }

    public override decimal GetExpenses()
    {
        return _children.Sum(c => c.GetExpenses()) + Expenses;
    }

    public void Add(EmployeeComponent component)
    {
        _children.Add(component);
    }

    public void Remove(EmployeeComponent component)
    {
        _ = _children.Remove(component);
    }
}