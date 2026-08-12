public sealed class Logger
{
    private static readonly Lazy<Logger> _instance = new(() => new Logger());

    private Logger()
    {
        System.Console.WriteLine("Logger oluşturuldu.");
    }

    public static Logger  Instance => _instance.Value;

    public   void Log(string message)
    {
        System.Console.WriteLine($"Loglama yapıldı: {message}");
    }

}