using System.Collections.Generic;

public class EnemyAbilities
{
    public List<string> Skills { get; set; }
    
    
    public EnemyAbilities(List<string> skills)
    {
        Skills = skills;
    }
}