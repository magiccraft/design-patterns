internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== State Pattern Örneği ===");

        Document doc = new Document("Yıllık Faaliyet Raporu");
        Console.WriteLine($"Başlangıç Durumu: {doc.State.GetStateName()}");

        // 1. Taslak aşamasında içerik giriliyor
        doc.Edit("2026 yılı ilk çeyrek büyüme oranı %12 olarak gerçekleşti.");

        // 2. Taslaktan direkt yayınlama denemesi (Geçersiz geçiş)
        Console.WriteLine("\n[Deneme: Taslaktan direkt yayınlama]");
        doc.Publish();

        // 3. İncelemeye gönderme
        Console.WriteLine("\n[İncelemeye Gönderme]");
        doc.SubmitForReview();
        Console.WriteLine($"Güncel Durum: {doc.State.GetStateName()}");

        // 4. İncelemedeyken düzenleme denemesi
        Console.WriteLine("\n[Deneme: İnceleme aşamasında düzenleme]");
        doc.Edit("Yeni satır ekleme");

        // 5. Yayınlama
        Console.WriteLine("\n[Onay ve Yayınlama]");
        doc.Publish();
        Console.WriteLine($"Güncel Durum: {doc.State.GetStateName()}");

        // 6. Yayınlanmış dokümanda revizyon (Otomatik olarak Taslak durumuna döner)
        Console.WriteLine("\n[Yayındaki Dokümanda Revizyon]");
        doc.Edit("Revize edilen 2026 yılı ilk çeyrek büyüme oranı %14'tür.");
        Console.WriteLine($"Güncel Durum: {doc.State.GetStateName()}");
    }
}
