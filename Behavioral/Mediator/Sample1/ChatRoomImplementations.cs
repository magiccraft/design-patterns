// Concrete Mediator (Kullanıcılar arasındaki iletişimi koordine eder)
public class ChatRoom : IChatRoomMediator
{
    private readonly Dictionary<string, User> _users = new Dictionary<string, User>(StringComparer.OrdinalIgnoreCase);

    public void RegisterUser(User user)
    {
        if (!_users.ContainsKey(user.Name))
        {
            _users[user.Name] = user;
            Console.WriteLine($"[Sohbet Odası] '{user.Name}' odaya katıldı.");
        }
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users.Values)
        {
            // Mesajı gönderen hariç diğer tüm kullanıcılara ilet
            if (user != sender)
            {
                user.Receive(message, sender.Name);
            }
        }
    }

    public void SendDirectMessage(string message, User sender, string receiverName)
    {
        if (_users.TryGetValue(receiverName, out var receiver))
        {
            receiver.Receive($"[Özel Mesaj]: {message}", sender.Name);
        }
        else
        {
            Console.WriteLine($"[Sohbet Odası] Hata: '{receiverName}' adlı kullanıcı bulunamadı!");
        }
    }
}

// Concrete Colleague (Somut Kullanıcı)
public class ChatUser : User
{
    public ChatUser(string name, IChatRoomMediator mediator) : base(name, mediator) { }

    public override void Send(string message)
    {
        Console.WriteLine($"\n[{Name} (Genel Mesaj)] -> {message}");
        _mediator.SendMessage(message, this);
    }

    public override void SendTo(string message, string receiverName)
    {
        Console.WriteLine($"\n[{Name} -> {receiverName} (Özel)] -> {message}");
        _mediator.SendDirectMessage(message, this, receiverName);
    }

    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"  [{Name} aldı ({senderName}'den)]: {message}");
    }
}
