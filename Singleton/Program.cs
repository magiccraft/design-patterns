

internal class Program
{
    private static void Main(string[] args)
    {
        var enemyManager = EnemyManager.Instance;
        
        enemyManager.ShowEnemies();
    }
}
