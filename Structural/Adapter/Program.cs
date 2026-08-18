internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Adapter Pattern Örneği ===");

        // 1. Standart ödeme işlemcisi
        Console.WriteLine("--- Standart Kredi Kartı İşlemi ---");
        IPaymentProcessor creditCard = new CreditCardProcessor();
        creditCard.ProcessPayment(1500.00m);

        Console.WriteLine();

        // 2. Adapter üzerinden PayPal ile ödeme
        Console.WriteLine("--- Adapter ile PayPal Entegrasyonu ---");
        PayPalService thirdPartyPayPal = new PayPalService();
        IPaymentProcessor payPalAdapter = new PayPalPaymentAdapter(thirdPartyPayPal, "kullanici@example.com");
        
        // İstemci kodu aynı IPaymentProcessor arayüzünü kullanarak PayPal üzerinden ödeme yapar
        payPalAdapter.ProcessPayment(3450.00m);
    }
}
