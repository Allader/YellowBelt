using System;

namespace Kata_10;

public interface ICharacter
{
    string Name { get; }
}

public interface IAttackable : ICharacter
{
    void TakeDamage(int damage);
}

public interface INpc : ICharacter
{
    void Dialogue();
}

public class Player : ICharacter, IAttackable
{
    public string Name { get; private set; } = "Player";
    public int Level { get; private set; } = 1;
    public int Damage { get; private set; } = 15;

    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"{Name} attacks {enemy.Name} for {Damage} damage!");
        enemy.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{Name} takes {damage} damage!");
        // Add health reduction if implemented
    }
}

public class Enemy : ICharacter, IAttackable
{
    public string Name { get; private set; } = "Goblin";
    public int Health { get; private set; } = 50;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage! Remaining health: {Health}");
    }
}

public class Npc : INpc
{
    public string Name { get; private set; } = "Villager";
    public string Speak { get; private set; } = "Welcome to the village!";

    public void Dialogue()
    {
        Console.WriteLine($"{Name} says: \"{Speak}\"");
    }
}

public class Merchant : INpc
{
    public string Name { get; private set; } = "Merchant";
    public string[] Inventory { get; private set; } = { "Sword", "Shield", "Potion" };

    public void Dialogue()
    {
        Console.WriteLine($"{Name} greets you: \"Take a look at my wares!\"");
    }

    public void Trade()
    {
        Console.WriteLine("Merchant have appeard and have items for sell!\n Sword, Shield, Potion");
        
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "Sword":
                Console.WriteLine("You bought item!");
                break;
            case "Shield":
                Console.WriteLine("You bought item!");
                break;
            case "Potion":
                Console.WriteLine("You bought item!");
                break;

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Enemy goblin = new Enemy();
        Npc villager = new Npc();
        Merchant merchant = new Merchant();

        
        Console.WriteLine("A wild Goblin appears!");
        player.Attack(goblin);

        
        Console.WriteLine("\nYou meet a Villager.");
        villager.Dialogue();

        
        Console.WriteLine("\nYou encounter a Merchant.");
        merchant.Dialogue();
        merchant.Trade();
    }
}