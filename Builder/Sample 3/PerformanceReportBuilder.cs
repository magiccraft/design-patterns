public class PerformanceReportBuilder : IReportBuilder
{
    Report _report = new Report();

    public Report Build()
    {
        return _report;
    }

    public IReportBuilder SetContent(string content)
    {
        _report.Content = content;
        return this;
    }

    public IReportBuilder SetDate(string date)
    {
        _report.Date = date;
        return this;
    }

    public IReportBuilder SetFooter(string footer)
    {
        _report.Footer = footer;
        return this;
    }

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = title;
        return this;
    }
}