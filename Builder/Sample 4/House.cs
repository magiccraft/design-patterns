//  Üretilecek karmaşık nesne (Product)
public class House
{
    List<string> _parts = new List<string>();

    public void AddPart(string part)
    {
        _parts.Add(part);
    }

    public void ShowHouse()
    {
        foreach (var part in _parts)
        {
            System.Console.WriteLine(part);
        }
    }


}