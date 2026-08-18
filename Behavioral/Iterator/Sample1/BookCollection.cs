// Concrete Aggregate
public class BookCollection : IAggregate<Book>
{
    private readonly List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public int Count => _books.Count;

    public Book this[int index] => _books[index];

    public IIterator<Book> CreateIterator()
    {
        return new BookIterator(this);
    }
}

// Concrete Iterator
public class BookIterator : IIterator<Book>
{
    private readonly BookCollection _collection;
    private int _currentIndex = 0;

    public BookIterator(BookCollection collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _currentIndex < _collection.Count;
    }

    public Book Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("Koleksiyonun sonuna ulaşıldı.");
        }

        Book item = _collection[_currentIndex];
        _currentIndex++;
        return item;
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}
