namespace ExamKata10;

public interface Icharacter
{
   public string Name { get; }
    
}

public interface IDamageable : Icharacter
{
    int Health { get; }
    void TakeDamage(int damage);
    
}

public interface IAttackable 
{
    void Attack(IDamageable target);
    
}

public interface ISpeakable
{
    void Speak(string text);
    
}

public interface Inventory
{
    string[] Items { get; }
}

public interface Iencounterable
{
    void Encounter();
}
public class Player : Icharacter, IDamageable, IAttackable, Inventory
{
    
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Experience { get; private set; }
    public int Level { get; private set; }
    public string[] Items { get; private set; }
    public Player(string name, int experience,int level = 1, int health = 50, string[] items = null)
    {
        Name = name;
        Health = health;
        Experience = experience;
        Level = level;
        Items = new string[] { };
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} taking {damage} damage");
        
    }

    public void Attack(IDamageable target)
    {
        int damage = 20;
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage ");
        target.TakeDamage(damage);
    }


    public void Heal(int healAmount)
    {
        healAmount = 10;
        Health += healAmount;
        Console.WriteLine($"{Name} heals {healAmount} health");

    }
    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"{Name} gained {exp} experience points!");
        LevelUp(); // Check if level-up is needed
    }

  public void LevelUp()
    {
        if (Experience >= 100)
        {
             Experience -= 100; // Deduct 100 EXP after leveling up
            Level++;           // Increase level
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congratulations! {Name} has leveled up to Level {Level}!");
        }
    }
}

public class Enemy : Icharacter, IDamageable, IAttackable, Iencounterable
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }
    public bool isAlive = true;

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
    
    
    public void TakeDamage(int damage)
    {
       Health -= damage;
       
    }

    public void Attack(IDamageable target)
    {
        int damage = 5;
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage ");
        target.TakeDamage(damage);
        
    }

    public void Encounter()
    {
        Console.WriteLine($"you have encountered {Name}! \nHe has {Health} health!");
        
    }
    
}

public class Npc : Icharacter, ISpeakable, Iencounterable
{
    public string Name { get; private set; }

    public Npc(string name)
    {
        Name = name;
    }

    public void Speak(string text)
    {
        Console.WriteLine($"{Name} says: {text}");
    }

    public void Encounter()
    {
        
        Console.WriteLine($"{Name} has appeared!");
        
        Console.WriteLine($"{Name} greets you warmly.");
    }
}

public class Merchant : Icharacter, ISpeakable, Iencounterable, Inventory
{
    public string Name { get; private set; }
    public string[] Items { get; private set; }

    public Merchant(string name,string[] items = null)
    {
        Name = name;
        Items = new string[] { };
    }
    public void Speak(string text)
    {
        Console.WriteLine($"{Name} says: {text}");
    }
    public void Encounter()
    {
        
        Console.WriteLine($"{Name} has appeared!");
        
        Console.WriteLine($"{Name} greets you warmly.");
    }
    
    
}

