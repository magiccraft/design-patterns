// Concrete Product A
public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"[Email] E-posta gönderildi: '{message}'");
    }
}
