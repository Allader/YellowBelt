namespace Kata7;

class Program
{
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Experience { get; set; }
    public class Player
    {
        public string Name;
        public static int Health = 150;
        public static int Level = 1;
        public static int Experience;

    }

    public class enemy(string type, int health)
    {
        public static string Type = "Orc";
        public static int Health;
        public static int damage = 10;

    }

    public static void Attack(int damage, enemy target)
    { //Psuedo-Code I want to set a dmg and set the enemy losing hp upon the attack action, if dead give exp
        
        enemy.Health -= damage;
        Console.WriteLine($"{enemy.Type} takes {damage} damage!");
        Console.WriteLine($"{enemy.Type} have {enemy.Health} health!");
        
        if (enemy.Health <= 0)
        {
            Console.WriteLine($"{enemy.Type} has been defeated!");
            GainExperience(100); // Gain experience for defeating an enemy
        }
    }

    public void TakeDamage(int damage)
    { //Pesudo-Code I want to make a method where Enemy is attacking player HOW? IDK
        if (Health <= 0)
        {
            
        }
    }

    public static void GainExperience(int experience)
    {
        
      //Pseudo-Code i want to change the EXP into level if exp ==100 +=1 lvl
      if (experience == 100)
      {
          Player.Level += 1;
          Console.WriteLine($"You gained {Player.Level} Level!.");
      }
    }
    static void Main(string[] args)
    {
        Player Arin = new Player();

        enemy Orc = new enemy("Orc", 150);

        Attack(150, Orc);
        

    }
}