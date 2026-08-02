public class AdditionalIngredients : IDrink
{
    protected IDrink _drink;
    public AdditionalIngredients(IDrink drink)
    {
        _drink = drink;
    }
    public virtual string AciklamaGetir()
    {
        return _drink.AciklamaGetir();
    }

    public virtual double GetPrice()
    {
        return _drink.GetPrice();
    }
}