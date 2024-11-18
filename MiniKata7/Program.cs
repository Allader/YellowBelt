namespace MiniKata7;

class Program
{
    
    public class Player(string name, int health)
    {
        private string name = "Arin";
        public int health = 100;
        public int level = 1;
    }

    public class Enemy(string type, int health ) 
    {
        public string type = "Goblin";
        public int health = 50;
        public int damage = 10;
    }
    static void Main(string[] args)
    {
        Player Arin = new Player("Arin", 100);
        Console.WriteLine($"Player Stats: \n * Health: {Arin.health} \n * Damage: {Arin.health}\n * Level: {Arin.level}\n");
        
        Enemy Goblin = new Enemy("Goblin", 50);
        Console.WriteLine($"Enemy info \n * Enemy type: {Goblin.type}\n * Health: {Goblin.health}\n * Damage: {Goblin.health}");
    
    }
}