// Standart Target Uygulaması
public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amountInTry)
    {
        Console.WriteLine($"[Kredi Kartı] {amountInTry:C2} tutarındaki ödeme başarıyla çekildi.");
    }
}
