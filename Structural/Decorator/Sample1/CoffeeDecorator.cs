// Base Decorator (Süsleyici temel sınıfı - Sarmalanan bileşen referansını tutar)
public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _decoratedCoffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _decoratedCoffee = coffee;
    }

    public virtual string GetDescription() => _decoratedCoffee.GetDescription();
    public virtual decimal GetCost() => _decoratedCoffee.GetCost();
}
