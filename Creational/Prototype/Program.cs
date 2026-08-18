internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Prototype Pattern Örneği ===");

        // Orijinal Nesne
        Document original = new Document("Tasarım Desenleri Rehberi", 250, "Ahmet Yılmaz");
        Console.WriteLine("--- Orijinal Belge ---");
        original.DisplayInfo();

        Console.WriteLine();

        // Shallow Copy Örneği
        Console.WriteLine("--- Shallow Copy (Yüzeysel Klon) ---");
        Document shallowCloned = (Document)original.Clone();
        shallowCloned.Title = "Klonlanmış Belge (Shallow)";
        // Reference type değiştirildiğinde her ikisi de etkilenir
        shallowCloned.Details.Author = "Mehmet Demir";

        Console.WriteLine("Klon değiştikten sonra Orijinal:");
        original.DisplayInfo();
        Console.WriteLine("Shallow Klon:");
        shallowCloned.DisplayInfo();

        Console.WriteLine();

        // Deep Copy Örneği
        Console.WriteLine("--- Deep Copy (Derin Klon) ---");
        Document deepCloned = original.DeepCopy();
        deepCloned.Title = "Bağımsız Belge (Deep Copy)";
        // Reference type değiştirildiğinde sadece deepCloned etkilenir
        deepCloned.Details.Author = "Zeynep Kaya";

        Console.WriteLine("Deep Klon değiştikten sonra Orijinal:");
        original.DisplayInfo();
        Console.WriteLine("Deep Klon:");
        deepCloned.DisplayInfo();
    }
}
