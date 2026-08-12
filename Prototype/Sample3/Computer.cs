public class Computer : IComputerPrototype
{
    public required string CPU { get; set; }
    public required string RAM { get; set; }
    public required string GPU { get; set; }
    public required List<string> Peripherals { get; set; }

    public IComputerPrototype Clone()
    {
        return (Computer)this.MemberwiseClone();
    }

    public Computer DeepCopy()
    {
        Computer deepCopiedComputer= (Computer)this.MemberwiseClone();
        deepCopiedComputer.Peripherals= new List<string>(this.Peripherals);

        return deepCopiedComputer;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine("Bilgisayar konfigürasyonu");
        System.Console.WriteLine($"CPU: {CPU}");
        System.Console.WriteLine($"RAM: {RAM}");
        System.Console.WriteLine($"GPU: {GPU}");
        System.Console.WriteLine($"Peripherals:" + string.Join(", ", Peripherals));
    }
}