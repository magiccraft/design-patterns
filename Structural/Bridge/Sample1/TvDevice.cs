// Concrete Implementor A
public class TvDevice : IDevice
{
    private bool _on = false;
    private int _volume = 30;
    private int _channel = 1;

    public bool IsEnabled => _on;

    public void Enable()
    {
        _on = true;
        Console.WriteLine("[TV] Televizyon açıldı.");
    }

    public void Disable()
    {
        _on = false;
        Console.WriteLine("[TV] Televizyon kapatıldı.");
    }

    public int GetVolume() => _volume;

    public void SetVolume(int percent)
    {
        _volume = Math.Clamp(percent, 0, 100);
        Console.WriteLine($"[TV] Ses seviyesi: {_volume}%");
    }

    public int GetChannel() => _channel;

    public void SetChannel(int channel)
    {
        _channel = channel;
        Console.WriteLine($"[TV] Kanal değiştirildi: {_channel}");
    }
}
