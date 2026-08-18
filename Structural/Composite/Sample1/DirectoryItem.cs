// Composite (Bileşik eleman - hem dosya hem de klasörleri içinde barındırabilir)
public class DirectoryItem : IFileSystemItem
{
    public string Name { get; }
    private readonly List<IFileSystemItem> _children = new List<IFileSystemItem>();

    public DirectoryItem(string name)
    {
        Name = name;
    }

    public void Add(IFileSystemItem item)
    {
        _children.Add(item);
    }

    public void Remove(IFileSystemItem item)
    {
        _children.Remove(item);
    }

    public long GetSizeInBytes()
    {
        long total = 0;
        foreach (var child in _children)
        {
            total += child.GetSizeInBytes();
        }
        return total;
    }

    public void Display(int depth)
    {
        string indent = new string('-', depth * 2);
        Console.WriteLine($"{indent} 📁 [{Name}] (Toplam: {GetSizeInBytes() / 1024.0:F1} KB)");

        foreach (var child in _children)
        {
            child.Display(depth + 1);
        }
    }
}
