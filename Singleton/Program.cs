

internal class Program
{
    private static void Main(string[] args)
    {
        var configurationManager = ConfigurationManager.Instance;
        System.Console.WriteLine(configurationManager.ConnectionString);
    }
}
