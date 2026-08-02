public sealed class DatabaseConnection
{
    private static readonly Lazy<DatabaseConnection> _instance =
        new Lazy<DatabaseConnection>(() => new DatabaseConnection());


    private DatabaseConnection()
    {
        System.Console.WriteLine("Veritabanına bağlandı.");
    }

    public static DatabaseConnection Instance => _instance.Value;

    public void ExecuteQuery(string query)
    {
        System.Console.WriteLine($"Sorgu çalıştırıldı: {query}");
    }

}