using System.Security.Cryptography;
using System.Threading.Channels;

namespace Kata_9;

public class Player
{
    public string Name = "Player";
    public int level = 1;
    public int damage = 15;

    public void Attack(int damage, Enemy enemy)
    {
        damage = 15;
        enemy.health -= damage;
        Console.WriteLine($"You attack {Enemy.type} for {damage} damage");

    }
}
public class Enemy
{
    public static string type = "Goblin";
    public int health = 15;
    public int damage;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Console.WriteLine($" {type} takes hit for {damage} damage");
        
    }
}

public class Npc
{
    public string Name = "Villager";
    public string dialogue = "Welcome to the  village!";

    public void Speak()
    {
        Console.WriteLine(dialogue);
    }
}

public class Merchant
{
    public string name = "Merchant";
    public string[] inventory = { "Sword", "Shield", "Potion" };
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
        Player Player = new Player();
        Enemy Goblin = new Enemy();
        Npc Npc = new Npc();
        Merchant Merchant = new Merchant();
        
        Player.Attack(15,Goblin);
        Goblin.TakeDamage(Player.damage);

        Npc.Speak();
        Merchant.Trade();

    }
}