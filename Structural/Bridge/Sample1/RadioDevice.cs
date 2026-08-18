// Concrete Implementor B
public class RadioDevice : IDevice
{
    private bool _on = false;
    private int _volume = 20;
    private int _channel = 88; // FM Frekansı

    public bool IsEnabled => _on;

    public void Enable()
    {
        _on = true;
        Console.WriteLine("[Radyo] Radyo açıldı.");
    }

    public void Disable()
    {
        _on = false;
        Console.WriteLine("[Radyo] Radyo kapatıldı.");
    }

    public int GetVolume() => _volume;

    public void SetVolume(int percent)
    {
        _volume = Math.Clamp(percent, 0, 100);
        Console.WriteLine($"[Radyo] Ses seviyesi: {_volume}%");
    }

    public int GetChannel() => _channel;

    public void SetChannel(int channel)
    {
        _channel = channel;
        Console.WriteLine($"[Radyo] Radyo frekansı ayarlandı: {_channel}.0 FM");
    }
}
