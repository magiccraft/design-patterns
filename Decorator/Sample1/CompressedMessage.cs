public class CompressedMessage:MessageDecorator
{
    public CompressedMessage(IMessage message) : base(message)
    {
        
    }

    public override string GetContent()
    {
        return base.GetContent() +" (Compressed)";
    }
}