public class Document : ICloneable
{
    //Value type 
    public string Title { get; set; }
    public int PageCount { get; set; }
    //Reference type
    public DocumentDetails Details { get; set; }

    public Document(string title, int pageCount, string author)
    {
        Title = title;
        PageCount = pageCount;
        Details = new DocumentDetails(author);
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public Document DeepCopy()
    {
        Document clonedDocument = (Document)this.MemberwiseClone();
        clonedDocument.Details = new DocumentDetails(this.Details.Author);
        return clonedDocument;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"Page Count: {PageCount}");
        System.Console.WriteLine($"Author: {Details.Author}");
    }
}