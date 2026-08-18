// Concrete Product B
public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"[SMS] SMS mesajı iletildi: '{message}'");
    }
}
