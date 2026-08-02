
//Base Decorator 
abstract public class MessageDecorator : IMessage
{
    protected IMessage _message;

    public MessageDecorator(IMessage message)
    {
        _message = message;
    }
    public virtual string GetContent()
    {
        return _message.GetContent();
    }

}
