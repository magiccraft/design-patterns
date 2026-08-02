public class Milk : AdditionalIngredients
{
    bool _isHot;
    public Milk(IDrink drink, bool isHot = true) : base(drink)
    {
        _isHot = isHot;
    }
    public override string AciklamaGetir()
    {
        string milkChoice = _isHot ? "Hot Milk"  : "Cold Milk ";
        return base.AciklamaGetir() +   milkChoice;

    }

    public override double GetPrice()
    {
        return base.GetPrice() + 2.5;
    }
}