// Iterator Interface
public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
}

// Aggregate (Iterable Collection) Interface
public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}

// Element Item
public class Book
{
    public string Title { get; }
    public string Author { get; }
    public decimal Price { get; }

    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
}
