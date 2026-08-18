internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Memento Pattern Örneği ===");

        TextEditor editor = new TextEditor();
        HistoryManager history = new HistoryManager();

        Console.WriteLine("\n--- Metin Yazılıyor ve Ara Durumlar Kaydediliyor ---");
        editor.Type("Merhaba Dünya! ");
        history.Push(editor.Save()); // Durum 1 kaydedildi

        editor.Type("Design Patterns öğreniyorum. ");
        history.Push(editor.Save()); // Durum 2 kaydedildi

        editor.Type("Bu kısım yanlış yazıldı ve silinecek...");

        Console.WriteLine("\n--- Geri Alma İşlemleri (Undo / Restore) ---");
        var previousState = history.Pop();
        if (previousState != null)
        {
            editor.Restore(previousState);
        }

        Console.WriteLine("\nBir adım daha geri alınıyor:");
        previousState = history.Pop();
        if (previousState != null)
        {
            editor.Restore(previousState);
        }
    }
}
