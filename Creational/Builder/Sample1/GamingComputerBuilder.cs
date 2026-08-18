// Concrete Builder
public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void Reset()
    {
        _computer = new Computer();
    }

    public IComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder SetGPU(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }

    public IComputerBuilder SetRAM(string ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public IComputerBuilder SetStorage(string storage)
    {
        _computer.Storage = storage;
        return this;
    }

    public IComputerBuilder SetPowerSupply(string powerSupply)
    {
        _computer.PowerSupply = powerSupply;
        return this;
    }

    public Computer Build()
    {
        Computer result = _computer;
        Reset(); // Yeni bir yapım için sıfırla
        return result;
    }
}
