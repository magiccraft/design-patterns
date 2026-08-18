// Concrete Products & Factory for Windows
public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("[Windows] Klasik Windows tarzı buton çizildi.");
    }

    public void OnClick()
    {
        Console.WriteLine("[Windows] Windows butonu tıklandı.");
    }
}

public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("[Windows] Windows onay kutusu (checkbox) çizildi.");
    }

    public void Toggle()
    {
        Console.WriteLine("[Windows] Windows onay kutusu işaretlendi/kaldırıldı.");
    }
}

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}
