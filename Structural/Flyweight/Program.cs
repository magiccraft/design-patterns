internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Flyweight Pattern Örneği ===");

        Forest forest = new Forest();

        // 10 adet Meşe ağacı dikiyoruz (Aynı TreeType paylaşılacak)
        for (int i = 0; i < 5; i++)
        {
            forest.PlantTree(i * 10, i * 20, "Meşe", "Yeşil", "MeseDokuVerisi_5MB");
        }

        // 5 adet Çam ağacı dikiyoruz (Aynı TreeType paylaşılacak)
        for (int i = 0; i < 5; i++)
        {
            forest.PlantTree(i * 15, i * 25, "Çam", "Koyu Yeşil", "CamDokuVerisi_5MB");
        }

        Console.WriteLine("\n--- Ormandaki Ağaçlar Çiziliyor ---");
        forest.Draw();

        Console.WriteLine();
        Console.WriteLine($"Toplam Dikilen Ağaç Sayısı: {forest.GetTotalTreeCount()}");
        Console.WriteLine($"Bellekte Oluşturulan Benzersiz TreeType Sayısı: {TreeFactory.GetCreatedTypeCount()}");
        Console.WriteLine("-> Flyweight sayesinde yüzlerce/binlerce nesne yerine sadece 2 adet ağır veri nesnesi bellekte tutuldu!");
    }
}
