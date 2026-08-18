// Concrete Subject (Borsa Fiyat Takipçisi)
public class StockMarket : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private string _symbol = string.Empty;
    private decimal _price;

    public void SetStockPrice(string symbol, decimal newPrice)
    {
        _symbol = symbol;
        _price = newPrice;
        Console.WriteLine($"\n[Borsa Sistemi] '{_symbol}' hissesi yeni fiyatı: {_price:C2}");
        Notify();
    }

    public void Attach(IObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_symbol, _price);
        }
    }
}

// Concrete Observer A: Bireysel Yatırımcı
public class Investor : IObserver
{
    public string Name { get; }

    public Investor(string name)
    {
        Name = name;
    }

    public void Update(string stockSymbol, decimal price)
    {
        Console.WriteLine($"  [Yatırımcı - {Name}] Bildirim: '{stockSymbol}' güncel fiyatı {price:C2}");
    }
}

// Concrete Observer B: Mobil Uygulama Bildirimi
public class MobileAppAlert : IObserver
{
    public string DeviceId { get; }

    public MobileAppAlert(string deviceId)
    {
        DeviceId = deviceId;
    }

    public void Update(string stockSymbol, decimal price)
    {
        Console.WriteLine($"  [Mobil Bildirim ({DeviceId})] 🔔 '{stockSymbol}' fiyatı değişti: {price:C2}");
    }
}
