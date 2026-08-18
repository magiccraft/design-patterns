// Concrete Command A: Işığı Açma Komutu
public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }

    public void Undo()
    {
        _light.TurnOff();
    }
}

// Concrete Command B: Işığı Kapatma Komutu
public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }

    public void Undo()
    {
        _light.TurnOn();
    }
}

// Invoker (Komutları çağıran ve geçmişi/undo mekanizmasını yöneten sınıf)
public class RemoteControl
{
    private readonly Stack<ICommand> _commandHistory = new Stack<ICommand>();

    public void SubmitAndExecute(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void PressUndo()
    {
        if (_commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop();
            Console.Write("[Kumanda: Geri Al (Undo)] -> ");
            lastCommand.Undo();
        }
        else
        {
            Console.WriteLine("[Kumanda] Geri alınacak komut bulunmuyor!");
        }
    }
}
