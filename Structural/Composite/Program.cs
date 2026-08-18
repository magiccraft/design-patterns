internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Composite Pattern Örneği ===");

        // Kök Klasör
        DirectoryItem rootDir = new DirectoryItem("ProjeKlasoru");

        // Dosyalar
        FileItem readme = new FileItem("README.md", 2048); // 2 KB
        FileItem gitignore = new FileItem(".gitignore", 512);

        rootDir.Add(readme);
        rootDir.Add(gitignore);

        // Alt Klasör: src
        DirectoryItem srcDir = new DirectoryItem("src");
        FileItem programCs = new FileItem("Program.cs", 4096);
        FileItem appSettings = new FileItem("appsettings.json", 1024);
        srcDir.Add(programCs);
        srcDir.Add(appSettings);

        // Alt Klasör: assets
        DirectoryItem assetsDir = new DirectoryItem("assets");
        FileItem logoPng = new FileItem("logo.png", 51200); // 50 KB
        assetsDir.Add(logoPng);

        srcDir.Add(assetsDir);
        rootDir.Add(srcDir);

        // Tüm ağaç yapısını ekrana bas ve toplam boyutu hesapla
        Console.WriteLine("Dosya Hiyerarşisi:");
        rootDir.Display(0);

        Console.WriteLine();
        Console.WriteLine($"Kök Klasörün Toplam Boyutu: {rootDir.GetSizeInBytes():N0} bayt");
    }
}
