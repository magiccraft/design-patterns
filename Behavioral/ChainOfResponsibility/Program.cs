internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Chain of Responsibility Pattern Örneği ===");

        // Sorumluluk Zincirini Kuruyoruz: Takım Lideri -> Müdür -> Genel Müdür
        Approver teamLead = new TeamLeadApprover("Ahmet");
        Approver manager = new ManagerApprover("Berna");
        Approver director = new DirectorApprover("Cemil");

        teamLead.SetNext(manager).SetNext(director);

        // Talepleri zincirin ilk halkasına gönderiyoruz
        Console.WriteLine("\n--- Talep 1: Ofis Kırtasiye Malzemeleri (3.500 TL) ---");
        teamLead.ProcessRequest(new ExpenseRequest("Ofis Kırtasiye Malzemeleri", 3500));

        Console.WriteLine("\n--- Talep 2: Geliştirici Bilgisayarı Satın Alımı (18.000 TL) ---");
        teamLead.ProcessRequest(new ExpenseRequest("Geliştirici Bilgisayarı Satın Alımı", 18000));

        Console.WriteLine("\n--- Talep 3: Şirket Sunucu Donanım Güncellemesi (65.000 TL) ---");
        teamLead.ProcessRequest(new ExpenseRequest("Şirket Sunucu Donanım Güncellemesi", 65000));

        Console.WriteLine("\n--- Talep 4: Yeni Şube Açılış Masrafı (250.000 TL) ---");
        teamLead.ProcessRequest(new ExpenseRequest("Yeni Şube Açılış Masrafı", 250000));
    }
}
