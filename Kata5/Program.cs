namespace Kata5;

class Program
{
    static void Main(string[] args)
    {
        AttackEnemy("Goblin", 20);
        HealPlayer("Arin", 15);
    }

    public static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"{enemyName} took {damage} damage!");
    }

    public static void HealPlayer(string playerName, int heal)
    {
        Console.WriteLine($"Player {playerName} healed {heal} health points!");
    }
    
    
    
}