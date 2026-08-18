// State Interface
public interface IDocumentState
{
    void Edit(Document document, string newText);
    void SubmitForReview(Document document);
    void Publish(Document document);
    string GetStateName();
}

// Context (Durumunu koruyan ve geçerli duruma göre davranış sergileyen sınıf)
public class Document
{
    public string Title { get; }
    public string Content { get; set; } = string.Empty;
    public IDocumentState State { get; set; }

    public Document(string title)
    {
        Title = title;
        State = new DraftState(); // Başlangıç durumu: Taslak
    }

    public void Edit(string newText)
    {
        State.Edit(this, newText);
    }

    public void SubmitForReview()
    {
        State.SubmitForReview(this);
    }

    public void Publish()
    {
        State.Publish(this);
    }
}
