public abstract class NotificationDecorator : INotificationMessage
{
    protected INotificationMessage _message;

    public NotificationDecorator(INotificationMessage message)
    {
        _message = message;
    }

    public virtual void SendMessage(string message)
    {
        _message.SendMessage(message);
    }
}

