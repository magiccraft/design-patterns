using System.ComponentModel;
using Microsoft.VisualBasic;

public sealed class DatabaseManager
{
    private static readonly Lazy<DatabaseManager> _instance =
             new Lazy<DatabaseManager>(() => new DatabaseManager());

    private DatabaseManager()
    {
        System.Console.WriteLine("Database manager oluşturuldu");
    }

    public static DatabaseManager Instance => _instance.Value;

    public void Connect()
    {
        System.Console.WriteLine("Veri tabanı bağlantısı kuruldu");
    }

    public void Disconnect()
    {
        System.Console.WriteLine("Veri tabanı bağlantısı koptu");
    }
}