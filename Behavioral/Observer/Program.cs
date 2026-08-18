internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Observer Pattern Örneği ===");

        StockMarket borsa = new StockMarket();

        // Gözlemciler (Observers) oluşturuluyor
        Investor ali = new Investor("Ali Demir");
        Investor canan = new Investor("Canan Yurt");
        MobileAppAlert mobileApp = new MobileAppAlert("iPhone-15-Pro");

        // Gözlemciler borsaya abone yapılıyor
        borsa.Attach(ali);
        borsa.Attach(canan);
        borsa.Attach(mobileApp);

        // Fiyat değişikliği tetikleniyor
        borsa.SetStockPrice("THYAO", 295.50m);
        borsa.SetStockPrice("ASELS", 62.80m);

        Console.WriteLine("\n--- Canan abonelikten ayrılıyor ---");
        borsa.Detach(canan);

        borsa.SetStockPrice("THYAO", 304.20m);
    }
}
