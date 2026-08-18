// Concrete Products & Factory for macOS
public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("[macOS] Yuvarlatılmış macOS tarzı buton çizildi.");
    }

    public void OnClick()
    {
        Console.WriteLine("[macOS] macOS butonu tıklandı.");
    }
}

public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("[macOS] macOS onay kutusu (checkbox) çizildi.");
    }

    public void Toggle()
    {
        Console.WriteLine("[macOS] macOS onay kutusu işaretlendi/kaldırıldı.");
    }
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}
