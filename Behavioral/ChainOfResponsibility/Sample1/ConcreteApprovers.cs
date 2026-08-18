// Concrete Handler 1: Takım Lideri (5.000 TL'ye kadar onay yetkisi)
public class TeamLeadApprover : Approver
{
    public TeamLeadApprover(string name) : base(name) { }

    public override void ProcessRequest(ExpenseRequest request)
    {
        if (request.Amount <= 5000)
        {
            Console.WriteLine($"[Takım Lideri - {Name}] '{request.Purpose}' için {request.Amount:C2} tutarındaki harcamayı ONAYLADI.");
        }
        else if (_nextApprover != null)
        {
            Console.WriteLine($"[Takım Lideri - {Name}] Yetki sınırı aşıldı ({request.Amount:C2} > 5.000 TL). Talep bir üst makama iletiliyor...");
            _nextApprover.ProcessRequest(request);
        }
        else
        {
            Console.WriteLine($"[Takım Lideri - {Name}] Harcama talebi onaylanamadı, zincirde başka yetkili yok!");
        }
    }
}

// Concrete Handler 2: Departman Müdürü (25.000 TL'ye kadar onay yetkisi)
public class ManagerApprover : Approver
{
    public ManagerApprover(string name) : base(name) { }

    public override void ProcessRequest(ExpenseRequest request)
    {
        if (request.Amount <= 25000)
        {
            Console.WriteLine($"[Müdür - {Name}] '{request.Purpose}' için {request.Amount:C2} tutarındaki harcamayı ONAYLADI.");
        }
        else if (_nextApprover != null)
        {
            Console.WriteLine($"[Müdür - {Name}] Yetki sınırı aşıldı ({request.Amount:C2} > 25.000 TL). Talep Genel Müdüre iletiliyor...");
            _nextApprover.ProcessRequest(request);
        }
        else
        {
            Console.WriteLine($"[Müdür - {Name}] Harcama talebi onaylanamadı!");
        }
    }
}

// Concrete Handler 3: Genel Müdür (100.000 TL'ye kadar onay yetkisi)
public class DirectorApprover : Approver
{
    public DirectorApprover(string name) : base(name) { }

    public override void ProcessRequest(ExpenseRequest request)
    {
        if (request.Amount <= 100000)
        {
            Console.WriteLine($"[Genel Müdür - {Name}] '{request.Purpose}' için {request.Amount:C2} tutarındaki harcamayı ONAYLADI.");
        }
        else
        {
            Console.WriteLine($"[Genel Müdür - {Name}] REDDEDİLDİ: {request.Amount:C2} tutarı şirket onay limitini (100.000 TL) aşıyor!");
        }
    }
}
