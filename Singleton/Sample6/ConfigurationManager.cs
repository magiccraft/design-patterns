public sealed  class ConfigurationManager 
{
    public string ConnectionString { get; set; } ="https://github.com/magiccraft";
    private static ConfigurationManager? _instance= null;
    public static ConfigurationManager Instance => _instance ??= new ConfigurationManager();
    private ConfigurationManager()
    {
        System.Console.WriteLine("Configuration manager created");
    }    
}