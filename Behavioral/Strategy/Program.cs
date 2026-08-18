internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Strategy Pattern Örneği ===");

        ShoppingCart cart = new ShoppingCart();
        cart.AddItem("Kablosuz Klavye", 1250.00m);
        cart.AddItem("Ergonomik Mouse", 850.00m);

        // 1. Kredi Kartı Stratejisi ile Ödeme
        Console.WriteLine("\n--- 1. Senaryo: Kredi Kartı Stratejisi ---");
        cart.SetPaymentStrategy(new CreditCardPayment("5400123456789012", "Caner Yıldız"));
        cart.Checkout();

        // 2. Yeni alışveriş ve PayPal Stratejisi
        Console.WriteLine("--- 2. Senaryo: PayPal Stratejisi ---");
        cart.AddItem("Monitör Standı", 650.00m);
        cart.SetPaymentStrategy(new PayPalPayment("caner@example.com"));
        cart.Checkout();

        // 3. Kripto Para Stratejisi
        Console.WriteLine("--- 3. Senaryo: Kripto Para Stratejisi ---");
        cart.AddItem("Mekanik Klavye Tuş Takımı", 450.00m);
        cart.SetPaymentStrategy(new CryptoPayment("0x71C...9B3F"));
        cart.Checkout();
    }
}
