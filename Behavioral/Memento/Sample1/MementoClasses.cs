// Memento (Durum nesnesi - Durumu değişmez/immutable olarak saklar)
public class EditorMemento
{
    public string Content { get; }
    public DateTime CreatedAt { get; }

    public EditorMemento(string content)
    {
        Content = content;
        CreatedAt = DateTime.Now;
    }
}

// Originator (Durumu oluşturan ve geri yükleyen ana sınıf)
public class TextEditor
{
    public string Content { get; private set; } = string.Empty;

    public void Type(string text)
    {
        Content += text;
        Console.WriteLine($"[Editör Güncellendi]: \"{Content}\"");
    }

    public void Clear()
    {
        Content = string.Empty;
        Console.WriteLine("[Editör]: İçerik temizlendi.");
    }

    // Mevcut durumun anlık görüntüsünü (Memento) alır
    public EditorMemento Save()
    {
        Console.WriteLine($"[Editör]: Anlık durum kaydedildi -> \"{Content}\"");
        return new EditorMemento(Content);
    }

    // Durumu Memento üzerinden geri yükler
    public void Restore(EditorMemento memento)
    {
        Content = memento.Content;
        Console.WriteLine($"[Editör]: Durum geri yüklendi -> \"{Content}\" ({memento.CreatedAt:HH:mm:ss})");
    }
}

// Caretaker (Muhafız - Memento geçmişini tutar ama memento içeriğini değiştirmez)
public class HistoryManager
{
    private readonly Stack<EditorMemento> _history = new Stack<EditorMemento>();

    public void Push(EditorMemento memento)
    {
        _history.Push(memento);
    }

    public EditorMemento? Pop()
    {
        if (_history.Count > 0)
        {
            return _history.Pop();
        }

        return null;
    }

    public int HistoryCount => _history.Count;
}
