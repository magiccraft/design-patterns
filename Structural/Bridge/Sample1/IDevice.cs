// Implementor Interface (Köprünün uygulama tarafı)
public interface IDevice
{
    bool IsEnabled { get; }
    void Enable();
    void Disable();
    int GetVolume();
    void SetVolume(int percent);
    int GetChannel();
    void SetChannel(int channel);
}
