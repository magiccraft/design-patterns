internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Bridge Pattern Örneği ===");

        // 1. Temel kumanda ile TV kontrolü
        Console.WriteLine("--- Temel Kumanda & TV ---");
        IDevice tv = new TvDevice();
        RemoteControl basicRemote = new RemoteControl(tv);
        basicRemote.TogglePower();
        basicRemote.VolumeUp();
        basicRemote.ChannelUp();

        Console.WriteLine();

        // 2. Gelişmiş kumanda ile Radyo kontrolü
        Console.WriteLine("--- Gelişmiş Kumanda & Radyo ---");
        IDevice radio = new RadioDevice();
        AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);
        advancedRemote.TogglePower();
        advancedRemote.VolumeUp();
        advancedRemote.Mute();
        advancedRemote.TogglePower();
    }
}
