internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Template Method Pattern Örneği ===");

        // PDF Veri Madenciliği Şablonu
        DataMiner pdfMiner = new PdfDataMiner();
        pdfMiner.Mine("finansal_rapor.pdf");

        // CSV Veri Madenciliği Şablonu
        DataMiner csvMiner = new CsvDataMiner();
        csvMiner.Mine("satis_listesi.csv");
    }
}
