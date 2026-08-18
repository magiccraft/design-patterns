internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Proxy Pattern (Virtual / Lazy Proxy) Örneği ===");

        // 1. Proxy nesnesi oluşturulur (Henüz dosya diskten yüklenmez)
        IImage image = new ProxyImage("4k_ultra_hd_manzara.png");

        Console.WriteLine("\n--- Resim İlk Kez Gösteriliyor (Diskten yükleme tetiklenecek) ---");
        image.Display();

        Console.WriteLine("\n--- Resim İkinci Kez Gösteriliyor (Tekrar diskten yüklenmez, önbellek kullanılır) ---");
        image.Display();
    }
}
