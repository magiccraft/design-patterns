// Command Interface
public interface ICommand
{
    void Execute();
    void Undo();
}

// Receiver (İşin fiilen yapıldığı hedef alıcı sınıf)
public class Light
{
    public string Location { get; }
    public bool IsOn { get; private set; }

    public Light(string location)
    {
        Location = location;
        IsOn = false;
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"[Lamba - {Location}] Işık AÇILDI. 💡");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"[Lamba - {Location}] Işık KAPATILDI. 🌑");
    }
}
