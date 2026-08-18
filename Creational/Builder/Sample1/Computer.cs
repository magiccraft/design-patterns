// Product
public class Computer
{
    public string CPU { get; set; } = string.Empty;
    public string GPU { get; set; } = string.Empty;
    public string RAM { get; set; } = string.Empty;
    public string Storage { get; set; } = string.Empty;
    public string PowerSupply { get; set; } = string.Empty;

    public void DisplayInfo()
    {
        Console.WriteLine($"İşlemci (CPU):  {CPU}");
        Console.WriteLine($"Ekran Kartı (GPU): {GPU}");
        Console.WriteLine($"Bellek (RAM):    {RAM}");
        Console.WriteLine($"Depolama:        {Storage}");
        Console.WriteLine($"Güç Kaynağı:     {PowerSupply}");
    }
}
