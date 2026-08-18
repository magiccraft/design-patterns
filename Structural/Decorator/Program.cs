internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Decorator Pattern Örneği ===");

        // 1. Sade Kahve
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.GetDescription()} -> Fiyat: {coffee.GetCost():C2}");

        // 2. Süt eklenmiş kahve
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} -> Fiyat: {coffee.GetCost():C2}");

        // 3. Şeker de eklenmiş kahve
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} -> Fiyat: {coffee.GetCost():C2}");

        // 4. Karamel şurubu eklenmiş kahve (Tüm süsleyiciler iç içe sarmalandı)
        coffee = new CaramelDecorator(coffee);
        Console.WriteLine($"Nihai Sipariş: {coffee.GetDescription()} -> Toplam Tutar: {coffee.GetCost():C2}");
    }
}
