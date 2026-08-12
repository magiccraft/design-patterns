public class Report
{
    //value type
    public string? ReportType { get; set; }
    public int RefreshIntervalSeconds { get; set; }

    //referance type
    public ReportStyle Style { get; set; }
    public List<string> Columns { get; set; }

    public Report(string reportType)
    {
        ReportType = reportType;
        RefreshIntervalSeconds = 30;
        Style = new ReportStyle("Red", "Arial");
        Columns = new List<string> { "Column1", "Column2", "Column3" };

        System.Console.WriteLine("Report nesnesi oluşturuldu.");
    }

    public Report DeepCopy()
    {
        //Nesnenin yüzeysel kopyası
        Report clonedReport = (Report)this.MemberwiseClone();

        //Referans tipli olan Style nesnesini üreet
        clonedReport.Style = new ReportStyle(this.Style.HeaderColor, this.Style.FontName);

        //Referans tipli olan Columns listesini üret
        clonedReport.Columns = new List<string>();
        clonedReport.Columns.AddRange(this.Columns);

        return clonedReport;
    }

    public void DisplayConfig()
    {
        System.Console.WriteLine($"Report Type: {ReportType}");
        System.Console.WriteLine($"Refresh Interval: {RefreshIntervalSeconds} seconds");
        System.Console.WriteLine($"Header Color: {Style.HeaderColor}");
        System.Console.WriteLine($"Font Name: {Style.FontName}");
        System.Console.WriteLine($"Number of Columns: {Columns.Count}");
    }

}