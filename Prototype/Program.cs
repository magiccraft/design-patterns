internal class Program
{
    private static void Main(string[] args)
    {
        var skillsNameList = new List<string> { "Double jump,", "Dash", };
        var skillList = new EnemyAbilities(skillsNameList);
        

        var originalEnemy = new Enemy(100, skillList);

        var shallowCopiedEnemy = originalEnemy.ShallowCopy();
        var deepCopiedEnemy = originalEnemy.DeepCopy();

        Console.WriteLine("Original Enemy:");
        Console.WriteLine($"HP: {originalEnemy.HP}");
        Console.WriteLine($"Skills:");
        foreach (var skill in originalEnemy.Abilities.Skills)
        {
            Console.WriteLine(skill);
        }

        Console.WriteLine("\nShallow Copied Enemy:");
        Console.WriteLine($"HP: {shallowCopiedEnemy.HP}");
        Console.WriteLine($"Skills:");
        foreach (var skill in shallowCopiedEnemy.Abilities.Skills)
        {
            Console.WriteLine(skill);
        }

        Console.WriteLine("\nDeep Copied Enemy:");
        Console.WriteLine($"HP: {deepCopiedEnemy.HP}");
        Console.WriteLine($"Skills:");
        foreach (var skill in deepCopiedEnemy.Abilities.Skills)
        {
            Console.WriteLine(skill);
        }

        System.Console.WriteLine("these 3 objects are same attiributies");
        System.Console.WriteLine("Let's look after make changes from original enemy");

        originalEnemy.HP = 150;
        originalEnemy.Abilities.Skills.Clear();
        originalEnemy.Abilities.Skills.AddRange("Damage reflection", "Power attack") ;


        System.Console.WriteLine("\nOriginal Enemy:");
        System.Console.WriteLine($"HP: {originalEnemy.HP}");
        System.Console.WriteLine($"Skills:");
        foreach (var skill in originalEnemy.Abilities.Skills)
        {
            System.Console.WriteLine(skill);
        }


        System.Console.WriteLine("\nShallow Copied Enemy:");
        System.Console.WriteLine($"HP: {shallowCopiedEnemy.HP}");
        System.Console.WriteLine($"Skills:");
        foreach (var skill in shallowCopiedEnemy.Abilities.Skills)
        {
            System.Console.WriteLine(skill);
        }

        System.Console.WriteLine("\nDeep Copied Enemy:");
        System.Console.WriteLine($"HP: {deepCopiedEnemy.HP}");
        System.Console.WriteLine($"Skills:");
        foreach (var skill in deepCopiedEnemy.Abilities.Skills)
        {
            System.Console.WriteLine(skill);
        }


    }
}