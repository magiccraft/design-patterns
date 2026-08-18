internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Abstract Factory Pattern Örneği ===");

        // Windows ortamı simülasyonu
        Console.WriteLine("--- Windows Arayüzü Başlatılıyor ---");
        IGUIFactory winFactory = new WindowsFactory();
        Application winApp = new Application(winFactory);
        winApp.RenderUI();
        winApp.Interact();

        Console.WriteLine();

        // macOS ortamı simülasyonu
        Console.WriteLine("--- macOS Arayüzü Başlatılıyor ---");
        IGUIFactory macFactory = new MacFactory();
        Application macApp = new Application(macFactory);
        macApp.RenderUI();
        macApp.Interact();
    }
}
