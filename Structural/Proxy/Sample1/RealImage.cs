// Real Subject (Gerçek nesne - Diskten/ağdan yükleme gibi ağır maliyetli işlem yapar)
public class RealImage : IImage
{
    private readonly string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"[RealImage] Diskten yüksek çözünürlüklü resim yükleniyor (Ağır işlem): '{_fileName}'...");
        Thread.Sleep(500); // Yükleme süresi simülasyonu
        Console.WriteLine($"[RealImage] '{_fileName}' başarıyla belleğe yüklendi.");
    }

    public void Display()
    {
        Console.WriteLine($"[RealImage] Resim ekranda gösteriliyor: '{_fileName}'");
    }
}
