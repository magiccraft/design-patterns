public class Computer
{
    public string? CPU { get; set; } 
    public string? GPU { get; set; }
    public string? RAM { get; set; }
    public string? SSD { get; set; } 

     public  void DısplayInfo()
    {
        System.Console.WriteLine("CPU: {0}", CPU);
        System.Console.WriteLine("GPU: {0}", GPU);
        System.Console.WriteLine("RAM: {0}", RAM);
        System.Console.WriteLine("SSD: {0}", SSD);
    
    }
    
    
}