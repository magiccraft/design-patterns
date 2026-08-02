public class CompressedExporter : ExporterDecorator
{
    public CompressedExporter(IExporter exporter) : base(exporter)
    {

    }

    public override string Export(string data)
    {

        return $"{base.Export(data)} -> [Compressed]";
    }

}