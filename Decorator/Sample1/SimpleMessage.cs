using System;

//Concrete Component (Temel Nesne)
public class SimpleMessage : IMessage
{
    public string GetContent()
    {
        return "This is a simple message.";
    }
}