// Abstract Class (Şablon Metodu ve İskelet Algoritmayı Tanımlar)
public abstract class DataMiner
{
    // Template Method (Algoritmanın genel çalışma adımlarını belirler, adımların sırası sabittir)
    public void Mine(string filePath)
    {
        Console.WriteLine($"\n[Veri Madenciliği Başladı]: {filePath}");
        OpenFile(filePath);
        string rawData = ExtractRawData();
        string parsedData = ParseData(rawData);
        AnalyzeData(parsedData);
        SendReport();
        CloseFile();
        Console.WriteLine("[Veri Madenciliği Tamamlandı.]");
    }

    // Ortak Adımlar (Base class'ta varsayılan olarak tanımlı)
    protected void OpenFile(string path)
    {
        Console.WriteLine($"  1. Dosya açıldı: {path}");
    }

    protected void AnalyzeData(string data)
    {
        Console.WriteLine($"  4. Veri analizi yapıldı (Özet çıkarıldı, eğilimler tespit edildi).");
    }

    protected void SendReport()
    {
        Console.WriteLine("  5. Analiz raporu yönetim paneline iletildi.");
    }

    protected void CloseFile()
    {
        Console.WriteLine("  6. Dosya kapatıldı ve kaynaklar serbest bırakıldı.");
    }

    // Alt sınıflar tarafından özelleştirilmesi gereken soyut adımlar
    protected abstract string ExtractRawData();
    protected abstract string ParseData(string rawData);
}

// Concrete Class A: PDF Veri Çıkarıcı
public class PdfDataMiner : DataMiner
{
    protected override string ExtractRawData()
    {
        Console.WriteLine("  2. PDF formatına özel ikili bayt ve metin katmanları okundu.");
        return "PDF_HAM_VERI";
    }

    protected override string ParseData(string rawData)
    {
        Console.WriteLine("  3. PDF tabloları ve metin blokları JSON formatına ayrıştırıldı.");
        return "{ 'type': 'PDF', 'status': 'Parsed' }";
    }
}

// Concrete Class B: CSV Veri Çıkarıcı
public class CsvDataMiner : DataMiner
{
    protected override string ExtractRawData()
    {
        Console.WriteLine("  2. CSV satır satır virgülle ayrılmış metin olarak okundu.");
        return "CSV_HAM_METIN";
    }

    protected override string ParseData(string rawData)
    {
        Console.WriteLine("  3. CSV sütunları başlık indekslerine göre nesnelere dönüştürüldü.");
        return "{ 'type': 'CSV', 'status': 'Parsed' }";
    }
}
