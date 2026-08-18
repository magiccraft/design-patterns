// Adapter (Uyumsuz PayPalService sınıfını IPaymentProcessor arayüzüne uyarlar)
public class PayPalPaymentAdapter : IPaymentProcessor
{
    private readonly PayPalService _payPalService;
    private readonly string _userEmail;
    private const decimal UsdExchangeRate = 34.50m; // Örnek kur çevrimi

    public PayPalPaymentAdapter(PayPalService payPalService, string userEmail)
    {
        _payPalService = payPalService;
        _userEmail = userEmail;
    }

    public void ProcessPayment(decimal amountInTry)
    {
        // TRY tutarını USD'ye dönüştürüp Adaptee metodunu çağırıyoruz
        double amountInUsd = (double)(amountInTry / UsdExchangeRate);
        Console.WriteLine($"[Adapter] {amountInTry:C2} TRY tutarı ${amountInUsd:F2} USD olarak dönüştürüldü.");
        
        _payPalService.SendPayment(_userEmail, amountInUsd);
    }
}
