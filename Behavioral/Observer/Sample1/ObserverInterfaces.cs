// Observer Interface
public interface IObserver
{
    void Update(string stockSymbol, decimal price);
}

// Subject (Observable) Interface
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
