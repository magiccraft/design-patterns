// Builder Interface (supports Fluent API chaining)
public interface IComputerBuilder
{
    IComputerBuilder SetCPU(string cpu);
    IComputerBuilder SetGPU(string gpu);
    IComputerBuilder SetRAM(string ram);
    IComputerBuilder SetStorage(string storage);
    IComputerBuilder SetPowerSupply(string powerSupply);
    Computer Build();
    void Reset();
}
