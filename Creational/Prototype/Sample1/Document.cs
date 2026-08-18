// Prototype Class with Shallow & Deep Copy support
public class Document : ICloneable
{
    // Value / Immutable Types
    public string Title { get; set; }
    public int PageCount { get; set; }

    // Reference Type
    public DocumentDetails Details { get; set; }

    public Document(string title, int pageCount, string author)
    {
        Title = title;
        PageCount = pageCount;
        Details = new DocumentDetails(author);
    }

    // Yüzeysel Kopyalama (Shallow Copy)
    public object Clone()
    {
        return this.MemberwiseClone();
    }

    // Derin Kopyalama (Deep Copy)
    public Document DeepCopy()
    {
        Document clonedDocument = (Document)this.MemberwiseClone();
        clonedDocument.Details = new DocumentDetails(this.Details.Author);
        return clonedDocument;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Başlık: {Title} | Sayfa: {PageCount} | Yazar: {Details.Author}");
    }
}
