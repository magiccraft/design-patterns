// Concrete Creator A
public class EmailNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}
