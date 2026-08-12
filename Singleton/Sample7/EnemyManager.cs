using Microsoft.VisualBasic;

public sealed class EnemyManager {
    private List<string> enemies = new List<string>();

    private static EnemyManager? _instance = null;

    
    private EnemyManager()
    {
        EnemyGenerator();
    }

    public static EnemyManager Instance => _instance ??= new EnemyManager();
  
    private void EnemyGenerator()
    {
        int numberOfEnemies = Random.Shared.Next(1, 11);

        for (int i = 0; i < numberOfEnemies; i++)
        {
            enemies.Add($"{i + 1}. enemy");
        }
    }

    public void ShowEnemies()
    {
        foreach (var enemy in enemies)
        {
            System.Console.WriteLine(enemy);
        }
    }
}