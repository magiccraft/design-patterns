internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Singleton Pattern Örneği ===");

        // İlk erişim - Nesne ilk kez oluşturulur
        DatabaseManager db1 = DatabaseManager.Instance;
        db1.Connect();
        db1.ExecuteQuery("SELECT * FROM Users");

        Console.WriteLine();

        // İkinci erişim - Var olan aynı örnek döner
        DatabaseManager db2 = DatabaseManager.Instance;
        db2.ExecuteQuery("UPDATE Users SET Status = 'Active' WHERE Id = 1");

        Console.WriteLine();
        Console.WriteLine($"db1 ve db2 aynı referansa mı sahip? {ReferenceEquals(db1, db2)}");
    }
}
