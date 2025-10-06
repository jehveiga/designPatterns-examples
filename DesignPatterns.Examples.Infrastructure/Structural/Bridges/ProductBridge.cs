namespace DesignPatterns.Examples.Infrastructure.Structural.Bridges;

public abstract class OldItem
{
    public string Title { get; set; }
    public decimal PricePerUnit { get; set; }

    public abstract decimal GetTotalPrice(decimal units);
}

public class OldProduct : OldItem
{
    public string Category { get; set; }

    public override decimal GetTotalPrice(decimal units)
    {
        throw new NotImplementedException();
    }
}

public class OldFood : OldItem
{
    public string NutritionLabel { get; set; }

    public override decimal GetTotalPrice(decimal units)
    {
        throw new NotImplementedException();
    }
}

public class ProductMeasuredByQuantity : OldProduct
{
    public override decimal GetTotalPrice(decimal units)
    {
        throw new NotImplementedException();
    }
}

public class ProductMeasureByKg : OldProduct
{
    public override decimal GetTotalPrice(decimal units)
    {
        throw new NotImplementedException();
    }
}

public class FoodMeasuredByQuantity : OldFood
{
    public override decimal GetTotalPrice(decimal units)
    {
        throw new NotImplementedException();
    }
}

public class FoodMeasuredByKg : OldFood
{
    public override decimal GetTotalPrice(decimal units)
    {
        throw new NotImplementedException();
    }
}

// Bridge
public abstract class Item
{
    protected readonly IUnit _unit;

    public Item(IUnit unit)
    {
        _unit = unit;
    }

    public string Title { get; set; }
    public decimal PricePerUnit { get; set; }

    public abstract decimal GetTotalPrice(decimal units);
}

public class ProductBridge : Item
{
    public ProductBridge(IUnit unit) : base(unit)
    {
    }

    public string Category { get; set; }

    public override decimal GetTotalPrice(decimal units)
    {
        if (!_unit.Validate(units))
            throw new ArgumentException();

        return units * PricePerUnit;
    }
}

public class Food : Item
{
    public Food(IUnit unit) : base(unit)
    {
    }

    public string NutritionLabel { get; set; }

    public override decimal GetTotalPrice(decimal units)
    {
        if (!_unit.Validate(units))
            throw new ArgumentException();

        return units * PricePerUnit;
    }
}

public interface IUnit
{
    decimal Minimum { get; set; }
    decimal Maximum { get; set; }

    bool Validate(decimal units);
}

public class Kg : IUnit
{
    public decimal Minimum { get; set; }
    public decimal Maximum { get; set; }

    public bool Validate(decimal units)
    {
        return units < 10;
    }
}

public class Quantity : IUnit
{
    public decimal Minimum { get; set; }
    public decimal Maximum { get; set; }

    public bool Validate(decimal units)
    {
        if (units % 1 != 0)
            return false;

        if (Minimum > units || Maximum < units)
            return false;

        return true;
    }
}