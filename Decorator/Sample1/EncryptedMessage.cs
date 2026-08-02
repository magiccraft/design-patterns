// Concrete Decorators (Ek Özellikler)
public class EncryptedMessage:MessageDecorator
{
    public EncryptedMessage(IMessage message) : base(message)
    {
        
    }
    public override string  GetContent()
    {
        return  base.GetContent() + " (Encrypted)";

    }
}