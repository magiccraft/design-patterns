// Visitor Interface (Her bir somut eleman türü için ziyaret metodunu tanımlar)
public interface IVisitor
{
    void VisitBook(BookItem book);
    void VisitElectronic(ElectronicItem electronic);
}

// Element Interface (Ziyaretçiyi kabul eden 'Accept' metodunu tanımlar)
public interface IElement
{
    void Accept(IVisitor visitor);
}

// Concrete Element A: Kitap
public class BookItem : IElement
{
    public string Title { get; }
    public decimal Price { get; }
    public double WeightKg { get; }

    public BookItem(string title, decimal price, double weightKg)
    {
        Title = title;
        Price = price;
        WeightKg = weightKg;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitBook(this);
    }
}

// Concrete Element B: Elektronik Eşya
public class ElectronicItem : IElement
{
    public string Model { get; }
    public decimal Price { get; }
    public double WeightKg { get; }

    public ElectronicItem(string model, decimal price, double weightKg)
    {
        Model = model;
        Price = price;
        WeightKg = weightKg;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitElectronic(this);
    }
}

// Concrete Visitor 1: KDV / Vergi Hesaplama Ziyaretçisi
public class TaxVisitor : IVisitor
{
    public decimal TotalTax { get; private set; } = 0;

    public void VisitBook(BookItem book)
    {
        // Kitaplarda KDV oranı %0 (muaf) veya %1
        decimal tax = book.Price * 0.01m;
        TotalTax += tax;
        Console.WriteLine($"[KDV Hesabı] Kitap ('{book.Title}'): {tax:C2} KDV (%1)");
    }

    public void VisitElectronic(ElectronicItem electronic)
    {
        // Elektronik ürünlerde %20 KDV
        decimal tax = electronic.Price * 0.20m;
        TotalTax += tax;
        Console.WriteLine($"[KDV Hesabı] Elektronik ('{electronic.Model}'): {tax:C2} KDV (%20)");
    }
}

// Concrete Visitor 2: Kargo Maliyeti Hesaplama Ziyaretçisi
public class ShippingVisitor : IVisitor
{
    public decimal TotalShippingCost { get; private set; } = 0;

    public void VisitBook(BookItem book)
    {
        // Kitap başına kg başı 15 TL kargo
        decimal cost = (decimal)(book.WeightKg * 15.0);
        TotalShippingCost += cost;
        Console.WriteLine($"[Kargo Hesabı] Kitap ('{book.Title}' - {book.WeightKg} kg): {cost:C2}");
    }

    public void VisitElectronic(ElectronicItem electronic)
    {
        // Elektronik ürünlerde özel korumalı kargo: kg başı 35 TL + 50 TL sigorta
        decimal cost = (decimal)(electronic.WeightKg * 35.0) + 50.00m;
        TotalShippingCost += cost;
        Console.WriteLine($"[Kargo Hesabı] Elektronik ('{electronic.Model}' - {electronic.WeightKg} kg): {cost:C2}");
    }
}
