// Refined Abstraction (Gelişmiş kumanda - Ekstra yetenekler sunar)
public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device)
    {
    }

    public void Mute()
    {
        Console.WriteLine("[Gelişmiş Kumanda] Cihazın sesi tamamen kapatıldı (Mute).");
        _device.SetVolume(0);
    }
}
