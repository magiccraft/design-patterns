// Abstraction (Köprünün soyutlama tarafı - Cihaz referansını köprü olarak tutar)
public class RemoteControl
{
    protected IDevice _device;

    public RemoteControl(IDevice device)
    {
        _device = device;
    }

    public void TogglePower()
    {
        if (_device.IsEnabled)
        {
            _device.Disable();
        }
        else
        {
            _device.Enable();
        }
    }

    public void VolumeDown()
    {
        _device.SetVolume(_device.GetVolume() - 10);
    }

    public void VolumeUp()
    {
        _device.SetVolume(_device.GetVolume() + 10);
    }

    public void ChannelDown()
    {
        _device.SetChannel(_device.GetChannel() - 1);
    }

    public void ChannelUp()
    {
        _device.SetChannel(_device.GetChannel() + 1);
    }
}
