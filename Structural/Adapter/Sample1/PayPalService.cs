// Adaptee (Dış kaynaktan gelen, uyumsuz metot ve parametrelere sahip 3. parti sınıf)
public class PayPalService
{
    public void SendPayment(string userEmail, double amountInUsd)
    {
        Console.WriteLine($"[PayPal Servisi] {userEmail} hesabına ${amountInUsd:F2} USD ödeme gönderildi.");
    }
}
