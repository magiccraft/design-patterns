// Director (Opsiyonel - Yaygın hazır montaj adımlarını yönetir)
public class ComputerDirector
{
    private readonly IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public Computer ConstructHighEndGamingPC()
    {
        return _builder
            .SetCPU("AMD Ryzen 9 7950X")
            .SetGPU("NVIDIA GeForce RTX 4090 24GB")
            .SetRAM("64GB DDR5 6000MHz")
            .SetStorage("2TB NVMe M.2 SSD")
            .SetPowerSupply("1000W 80+ Gold")
            .Build();
    }

    public Computer ConstructStandardOfficePC()
    {
        return _builder
            .SetCPU("Intel Core i5-13400")
            .SetGPU("Intel UHD Graphics (Entegre)")
            .SetRAM("16GB DDR4 3200MHz")
            .SetStorage("512GB NVMe SSD")
            .SetPowerSupply("500W Bronze")
            .Build();
    }
}
