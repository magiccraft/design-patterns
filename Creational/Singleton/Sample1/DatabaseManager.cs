// Singleton Pattern - Thread-safe Lazy Initialization
public sealed class DatabaseManager
{
    private static readonly Lazy<DatabaseManager> _instance = 
        new Lazy<DatabaseManager>(() => new DatabaseManager());

    public string ConnectionString { get; private set; }
    public bool IsConnected { get; private set; }

    // Private constructor ensures no external instantiation
    private DatabaseManager()
    {
        ConnectionString = "Server=localhost;Database=AppDb;Trusted_Connection=True;";
        IsConnected = false;
        Console.WriteLine("[DatabaseManager] Yeni bir veritabanı yöneticisi örneği oluşturuldu.");
    }

    public static DatabaseManager Instance => _instance.Value;

    public void Connect()
    {
        if (!IsConnected)
        {
            IsConnected = true;
            Console.WriteLine($"[DatabaseManager] Veritabanına bağlanıldı: {ConnectionString}");
        }
        else
        {
            Console.WriteLine("[DatabaseManager] Zaten aktif bir bağlantı mevcut.");
        }
    }

    public void ExecuteQuery(string query)
    {
        if (IsConnected)
        {
            Console.WriteLine($"[DatabaseManager] Sorgu çalıştırılıyor: '{query}'");
        }
        else
        {
            Console.WriteLine("[DatabaseManager] Hata: Önce veritabanına bağlanmalısınız!");
        }
    }
}
