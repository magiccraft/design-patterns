public class EncryptedExporter : ExporterDecorator
{

    public EncryptedExporter(IExporter exporter) : base(exporter)
    {

    }

    public override string Export(string data)
    {
        return $"{base.Export(data)} -> [Encrypted]";
    }
}


