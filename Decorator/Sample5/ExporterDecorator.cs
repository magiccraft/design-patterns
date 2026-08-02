public class ExporterDecorator : IExporter
{
    protected IExporter _exporter;

    public ExporterDecorator(IExporter exporter)
    {
        _exporter = exporter;
    }
    public virtual string Export(string data)
    {
        return _exporter.Export(data);
    }
}


    


