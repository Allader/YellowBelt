namespace YellowBelt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Attack(15);
        Heal(10);

    }
    public static void Attack(int damage)
    {
                 Console.WriteLine($"Player dealt {damage} damage!"); 
    }

    public static void Heal(int heal)
    {
        Console.WriteLine($"Player healed for {heal} points!");
    }
}