// Context (Stratejiyi dinamik olarak değiştirebilen ve çalıştıran sınıf)
public class ShoppingCart
{
    private IPaymentStrategy? _paymentStrategy;
    private readonly List<(string Item, decimal Price)> _items = new List<(string, decimal)>();

    public void AddItem(string item, decimal price)
    {
        _items.Add((item, price));
        Console.WriteLine($"[Sepet] Ürün eklendi: {item} ({price:C2})");
    }

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        _paymentStrategy = strategy;
    }

    public void Checkout()
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("[Sepet] Hata: Lütfen önce bir ödeme yöntemi seçiniz!");
            return;
        }

        decimal total = 0;
        foreach (var item in _items)
        {
            total += item.Price;
        }

        Console.WriteLine($"\n[Sepet] Toplam Sepet Tutarı: {total:C2}. Ödeme başlatılıyor...");
        _paymentStrategy.Pay(total);
        _items.Clear();
        Console.WriteLine("[Sepet] Sipariş başarıyla tamamlandı.\n");
    }
}
