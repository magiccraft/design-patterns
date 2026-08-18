// Concrete Creator B
public class SmsNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}
