// Request Model
public class ExpenseRequest
{
    public string Purpose { get; }
    public decimal Amount { get; }

    public ExpenseRequest(string purpose, decimal amount)
    {
        Purpose = purpose;
        Amount = amount;
    }
}

// Handler Base Class
public abstract class Approver
{
    protected Approver? _nextApprover;
    public string Name { get; }

    public Approver(string name)
    {
        Name = name;
    }

    public Approver SetNext(Approver nextApprover)
    {
        _nextApprover = nextApprover;
        return nextApprover; // Zincirleme kurulum için sonraki halkayı döndürür
    }

    public abstract void ProcessRequest(ExpenseRequest request);
}
