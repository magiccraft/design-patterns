// Concrete Decorators
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => $"{base.GetDescription()} + Süt";
    public override decimal GetCost() => base.GetCost() + 12.50m;
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => $"{base.GetDescription()} + Şeker";
    public override decimal GetCost() => base.GetCost() + 3.00m;
}

public class CaramelDecorator : CoffeeDecorator
{
    public CaramelDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => $"{base.GetDescription()} + Karamel Şurubu";
    public override decimal GetCost() => base.GetCost() + 18.00m;
}
