// Concrete State 1: Taslak (Draft)
public class DraftState : IDocumentState
{
    public string GetStateName() => "Taslak (Draft)";

    public void Edit(Document document, string newText)
    {
        document.Content = newText;
        Console.WriteLine($"[Taslak Durumu] Doküman düzenlendi: \"{document.Content}\"");
    }

    public void SubmitForReview(Document document)
    {
        Console.WriteLine("[Taslak Durumu] Doküman incelemeye gönderildi. Durum -> İncelemede (Under Review)");
        document.State = new ReviewState();
    }

    public void Publish(Document document)
    {
        Console.WriteLine("[Taslak Durumu] HATA: Taslak durumundaki doküman doğrudan yayınlanamaz! Önce incelemeye gönderilmelidir.");
    }
}

// Concrete State 2: İncelemede (Under Review)
public class ReviewState : IDocumentState
{
    public string GetStateName() => "İncelemede (Under Review)";

    public void Edit(Document document, string newText)
    {
        Console.WriteLine("[İncelemede] HATA: İnceleme aşamasındaki doküman doğrudan düzenlenemez! Önce taslağa çekilmelidir.");
    }

    public void SubmitForReview(Document document)
    {
        Console.WriteLine("[İncelemede] Doküman zaten inceleme aşamasında.");
    }

    public void Publish(Document document)
    {
        Console.WriteLine("[İncelemede] Doküman onaylandı ve YAYINLANDI! Durum -> Yayınlandı (Published)");
        document.State = new PublishedState();
    }
}

// Concrete State 3: Yayınlandı (Published)
public class PublishedState : IDocumentState
{
    public string GetStateName() => "Yayınlandı (Published)";

    public void Edit(Document document, string newText)
    {
        Console.WriteLine("[Yayınlandı] Yayınlanmış dokümanda değişiklik yapıldı! Doküman yeniden 'Taslak' durumuna alındı.");
        document.Content = newText;
        document.State = new DraftState();
    }

    public void SubmitForReview(Document document)
    {
        Console.WriteLine("[Yayınlandı] Doküman zaten yayında.");
    }

    public void Publish(Document document)
    {
        Console.WriteLine("[Yayınlandı] Doküman zaten yayınlanmış durumda.");
    }
}
