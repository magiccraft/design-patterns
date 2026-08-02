// sample 1-2-3 fluent api, sample 4 geleneksel builder
internal class Program
{
    private static void Main(string[] args)
    {
        // Computer gamingPC = new DesktopComputerBuilder()
        //     .SetCpu("i7 14700KF")
        //     .SetGpu("RTX 5070")
        //     .SetRam("32GB")
        //     .SetSsd("1TB")
        //     .Build();

        // gamingPC.DısplayInfo();

        // UserProfile userProfile = new UserProfileBuilder()
        //     .SetName("Aybars")
        //     .Build();

        // userProfile.DisplayInfo();

        // Report report = new PerformanceReportBuilder()
        //     .SetTitle("Performance Report")
        //     .SetContent("İçerik")
        //     .SetDate("Tarih")
        //     .SetFooter("Footer")
        //     .Build();

        // report.ShowReport(report);


        IHouseBuilder luxuryHouseBuilder = new LuxuryHouseBuilder();
        Contractor contractor = new Contractor(luxuryHouseBuilder);
        contractor.ConstructHouse();
        House house = luxuryHouseBuilder.GetHouse();
        house.ShowHouse();
    

    }
}