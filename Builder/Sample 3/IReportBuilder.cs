public interface IReportBuilder
{
     IReportBuilder SetTitle(string title);
     IReportBuilder SetContent(string content);
     IReportBuilder SetFooter(string footer);
     IReportBuilder SetDate(string date);

     Report Build();

}