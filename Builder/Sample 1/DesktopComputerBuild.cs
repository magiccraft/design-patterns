public class DesktopComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public IComputerBuilder SetCpu(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder SetGpu(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }

    public IComputerBuilder SetRam(string ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public IComputerBuilder SetSsd(string ssd)
    {
        _computer.SSD = ssd;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}