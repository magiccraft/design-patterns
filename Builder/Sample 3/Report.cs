public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Footer { get; set; }
    public string Date { get; set; }
    
    public void ShowReport(Report report)
    {
        System.Console.WriteLine($"Title: {report.Title}");
        System.Console.WriteLine($"Content: {report.Content}");
        System.Console.WriteLine($"Footer: {report.Footer}");
        System.Console.WriteLine($"Date: {report.Date}");
    }
    
}