// Leaf (Hiyerarşinin yaprak elemanı - alt eleman barındırmaz)
public class FileItem : IFileSystemItem
{
    public string Name { get; }
    private readonly long _sizeInBytes;

    public FileItem(string name, long sizeInBytes)
    {
        Name = name;
        _sizeInBytes = sizeInBytes;
    }

    public long GetSizeInBytes() => _sizeInBytes;

    public void Display(int depth)
    {
        string indent = new string('-', depth * 2);
        Console.WriteLine($"{indent} 📄 {Name} ({_sizeInBytes / 1024.0:F1} KB)");
    }
}
