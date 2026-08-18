// Target Interface (Sistemimizin beklediği standart arayüz)
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amountInTry);
}
