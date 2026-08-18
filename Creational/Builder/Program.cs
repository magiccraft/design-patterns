internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Builder Pattern Örneği ===");

        // 1. Fluent Builder ile Özel Bilgisayar Toplama
        Console.WriteLine("--- 1. Özel Konfigürasyon Bilgisayar ---");
        IComputerBuilder customBuilder = new GamingComputerBuilder();
        Computer customPC = customBuilder
            .SetCPU("Apple M3 Max")
            .SetGPU("40-core GPU")
            .SetRAM("64GB Unified")
            .SetStorage("1TB NVMe SSD")
            .SetPowerSupply("140W USB-C Adapter")
            .Build();

        customPC.DisplayInfo();

        Console.WriteLine();

        // 2. Director Kullanarak Hazır Şablon Bilgisayar Üretme
        Console.WriteLine("--- 2. Director ile Hazır Gaming PC ---");
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        ComputerDirector director = new ComputerDirector(gamingBuilder);
        Computer gamingPC = director.ConstructHighEndGamingPC();

        gamingPC.DisplayInfo();
    }
}
