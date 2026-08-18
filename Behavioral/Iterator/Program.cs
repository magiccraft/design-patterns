internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Iterator Pattern Örneği ===");

        // Koleksiyon oluşturuluyor
        BookCollection library = new BookCollection();
        library.AddBook(new Book("Design Patterns: Elements of Reusable Object-Oriented Software", "Erich Gamma et al.", 450.00m));
        library.AddBook(new Book("Clean Code", "Robert C. Martin", 320.00m));
        library.AddBook(new Book("Refactoring", "Martin Fowler", 380.00m));
        library.AddBook(new Book("Domain-Driven Design", "Eric Evans", 420.00m));

        // Iterator üzerinden koleksiyon geziliyor
        IIterator<Book> iterator = library.CreateIterator();

        Console.WriteLine("\n--- Kitap Koleksiyonu Geziliyor (Iterator) ---");
        int index = 1;
        while (iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine($"{index++}. Kitap: '{book.Title}' | Yazar: {book.Author} | Fiyat: {book.Price:C2}");
        }
    }
}
