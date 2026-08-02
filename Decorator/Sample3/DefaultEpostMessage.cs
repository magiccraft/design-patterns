public class DefaultEpostMessage: INotificationMessage
{ 
    public void SendMessage(string message)
    {
        Console.WriteLine($"E-posta gönderildi : {message}");
    }
 
}