public class SmsMessage : NotificationDecorator
{
    public SmsMessage(INotificationMessage message) : base(message)
    {
        
    }

    public override void SendMessage(string message)
    {
        base.SendMessage(message);
        System.Console.WriteLine("SMS gönderildi: {0}", message);
    }

    }

