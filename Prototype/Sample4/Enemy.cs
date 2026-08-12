
public class Enemy 
{
   public int HP { get; set; }

    public EnemyAbilities Abilities { get; set; }
    
    public Enemy(int _HP, EnemyAbilities abilities)
    {
       HP=_HP;
       Abilities=abilities;
    
    }  

    public Enemy ShallowCopy()
    {
        return (Enemy)this.MemberwiseClone();
    
    }

    public Enemy DeepCopy()
    {   
        Enemy enemy= (Enemy)this.MemberwiseClone();
        enemy.Abilities= new EnemyAbilities(new List<string>(this.Abilities.Skills));
        return enemy;
    }         
}