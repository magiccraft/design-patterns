// Flyweight Factory (Daha önce üretilen Flyweight nesnelerini önbellekte saklar ve tekrar kullanır)
public class TreeFactory
{
    private static readonly Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

    public static TreeType GetTreeType(string name, string color, string textureData)
    {
        string key = $"{name}_{color}";

        if (!_treeTypes.TryGetValue(key, out var type))
        {
            type = new TreeType(name, color, textureData);
            _treeTypes[key] = type;
            Console.WriteLine($"[TreeFactory] Yeni TreeType oluşturuldu: {name} ({color})");
        }

        return type;
    }

    public static int GetCreatedTypeCount() => _treeTypes.Count;
}

// Context (Dışsal Durum - Extrinsic State: Her ağaca özel benzersiz koordinatlar)
public class Tree
{
    private readonly int _x;
    private readonly int _y;
    private readonly TreeType _type; // Paylaşılan Flyweight nesnesi referansı

    public Tree(int x, int y, TreeType type)
    {
        _x = x;
        _y = y;
        _type = type;
    }

    public void Draw()
    {
        _type.Draw(_x, _y);
    }
}

// Client
public class Forest
{
    private readonly List<Tree> _trees = new List<Tree>();

    public void PlantTree(int x, int y, string name, string color, string textureData)
    {
        TreeType type = TreeFactory.GetTreeType(name, color, textureData);
        Tree tree = new Tree(x, y, type);
        _trees.Add(tree);
    }

    public void Draw()
    {
        foreach (var tree in _trees)
        {
            tree.Draw();
        }
    }

    public int GetTotalTreeCount() => _trees.Count;
}
