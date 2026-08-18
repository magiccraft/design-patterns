// Proxy (Vekil Nesne - Virtual/Caching Proxy: Sadece ihtiyaç duyulduğunda RealImage'i oluşturur ve bellekte saklar)
public class ProxyImage : IImage
{
    private readonly string _fileName;
    private RealImage? _realImage;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
        // Not: Henüz diskten yükleme yapılmadı (Lazy Loading / Virtual Proxy)
        Console.WriteLine($"[ProxyImage] Proxy oluşturuldu (Resim henüz diske dokunulmadan referanslandı): '{_fileName}'");
    }

    public void Display()
    {
        if (_realImage == null)
        {
            Console.WriteLine("[ProxyImage] Resim ilk kez gösterilecek, gerçek nesne oluşturuluyor...");
            _realImage = new RealImage(_fileName);
        }
        else
        {
            Console.WriteLine("[ProxyImage] Resim zaten bellekte mevcut (Önbellekten çağrılıyor).");
        }

        _realImage.Display();
    }
}
