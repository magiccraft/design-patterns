// Creator (Abstract Factory Class)
public abstract class NotificationFactory
{
    // Factory Method
    public abstract INotification CreateNotification();

    // İş mantığı (Core business logic that uses the product)
    public void NotifyUser(string message)
    {
        INotification notification = CreateNotification();
        notification.Send(message);
    }
}
