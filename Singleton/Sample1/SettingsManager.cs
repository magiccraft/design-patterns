public sealed class SettingsManager
{
    private static readonly Lazy<SettingsManager> _instance = new Lazy<SettingsManager>(() => new SettingsManager());

    public string Theme { get; set; }
    public string Language { get; set; }
    public int FontSize { get; set; }

    public SettingsManager()
    {
        System.Console.WriteLine("Ayarlar yüklendi.");
    }

    public static SettingsManager Instance => _instance.Value;

    public void ShowSettigs()
    {
        System.Console.WriteLine($"Tema: {Theme}");
        System.Console.WriteLine($"Dil: {Language}");
        System.Console.WriteLine($"Yazı Boyutu: {FontSize}");
    }

}