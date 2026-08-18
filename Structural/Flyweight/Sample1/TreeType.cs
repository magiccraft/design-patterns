// Flyweight (İçsel/Ortak Durum - Intrinsic State: Değişmeyen ve paylaşılan veriler)
public class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public string TextureData { get; } // Büyük bellek kaplayan doku verisi simülasyonu

    public TreeType(string name, string color, string textureData)
    {
        Name = name;
        Color = color;
        TextureData = textureData;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"[Ağaç Çizimi] ({x}, {y}) konumunda '{Name}' türünde, {Color} renkli ağaç çizildi.");
    }
}
