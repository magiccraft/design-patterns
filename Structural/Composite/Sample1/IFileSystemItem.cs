// Component Interface
public interface IFileSystemItem
{
    string Name { get; }
    long GetSizeInBytes();
    void Display(int depth);
}
