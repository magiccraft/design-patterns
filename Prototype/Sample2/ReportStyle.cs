public class ReportStyle
{
    public string HeaderColor { get; set; }
    public string FontName { get; set; }

    public ReportStyle(string headerColor, string fontName)
    {
        HeaderColor = headerColor;
        FontName = fontName;
    }
}


