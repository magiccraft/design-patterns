internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Visitor Pattern Örneği ===");

        // Alışveriş sepetindeki farklı tipteki nesneler
        List<IElement> cart = new List<IElement>
        {
            new BookItem("Refactoring & Design Patterns", 350.00m, 0.8),
            new BookItem("Clean Architecture", 280.00m, 0.6),
            new ElectronicItem("Kablosuz Kulaklık", 2400.00m, 0.3),
            new ElectronicItem("4K Monitör", 12000.00m, 6.5)
        };

        // 1. Ziyaretçi: Vergi (KDV) Hesaplama
        Console.WriteLine("\n--- 1. Vergi (KDV) Ziyaretçisi Uygulanıyor ---");
        TaxVisitor taxVisitor = new TaxVisitor();
        foreach (var item in cart)
        {
            item.Accept(taxVisitor);
        }
        Console.WriteLine($"-> Toplam Vergi (KDV): {taxVisitor.TotalTax:C2}");

        // 2. Ziyaretçi: Kargo Maliyeti Hesaplama
        Console.WriteLine("\n--- 2. Kargo Hesaplama Ziyaretçisi Uygulanıyor ---");
        ShippingVisitor shippingVisitor = new ShippingVisitor();
        foreach (var item in cart)
        {
            item.Accept(shippingVisitor);
        }
        Console.WriteLine($"-> Toplam Kargo Ücreti: {shippingVisitor.TotalShippingCost:C2}");
    }
}
