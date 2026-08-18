// Strategy Interface
public interface IPaymentStrategy
{
    void Pay(decimal amount);
}

// Concrete Strategy 1: Kredi Kartı ile Ödeme
public class CreditCardPayment : IPaymentStrategy
{
    private readonly string _cardNumber;
    private readonly string _cardHolder;

    public CreditCardPayment(string cardNumber, string cardHolder)
    {
        _cardNumber = cardNumber;
        _cardHolder = cardHolder;
    }

    public void Pay(decimal amount)
    {
        string maskedCard = _cardNumber.Length >= 4 
            ? "****-****-****-" + _cardNumber[^4..] 
            : _cardNumber;
        Console.WriteLine($"[Kredi Kartı] {_cardHolder} ({maskedCard}) kartından {amount:C2} tahsil edildi.");
    }
}

// Concrete Strategy 2: PayPal ile Ödeme
public class PayPalPayment : IPaymentStrategy
{
    private readonly string _email;

    public PayPalPayment(string email)
    {
        _email = email;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"[PayPal] {_email} hesabı üzerinden {amount:C2} ödeme yapıldı.");
    }
}

// Concrete Strategy 3: Kripto Para (Bitcoin / USDT) ile Ödeme
public class CryptoPayment : IPaymentStrategy
{
    private readonly string _walletAddress;

    public CryptoPayment(string walletAddress)
    {
        _walletAddress = walletAddress;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"[Kripto Cüzdan] {_walletAddress} cüzdan adresine {amount:C2} karşılığı transfer sağlandı.");
    }
}
