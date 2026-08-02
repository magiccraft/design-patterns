public interface IComputerBuilder
{
    IComputerBuilder SetCpu(string cpu);
    IComputerBuilder SetGpu(string gpu);
    IComputerBuilder SetRam(string ram);
    IComputerBuilder SetSsd(string ssd);

    Computer Build();

}