namespace YellowBelt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        static void Attack(int damage)
        {
            Console.WriteLine($"Player dealt {damage} damage!");
        }
        
        Console.WriteLine(Attack);
        
    }
}