// Mediator Interface
public interface IChatRoomMediator
{
    void RegisterUser(User user);
    void SendMessage(string message, User sender);
    void SendDirectMessage(string message, User sender, string receiverName);
}

// Colleague (Meslektaş - Temel kullanıcı sınıfı, arabulucu referansına sahiptir)
public abstract class User
{
    protected IChatRoomMediator _mediator;
    public string Name { get; }

    public User(string name, IChatRoomMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void SendTo(string message, string receiverName);
    public abstract void Receive(string message, string senderName);
}
