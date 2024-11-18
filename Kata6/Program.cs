namespace Kata6;

class Program
{
    static void Main(string[] args)
    {
        string[] mobs = { "Goblin", "Orc", "Troll", "Dragon", "Skeleton" };
        
        Console.WriteLine("Enemies:");
        foreach (string mob in mobs)
        {
            Console.WriteLine(mob);
        }

        List<string> inventory = new List<string>() { "Sword", "Shield", "Potion" };
        
        Console.WriteLine("\nInitial Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }
        inventory.Add("Helmet");
        inventory.Add("Armor");
        inventory.Remove("Potion");
        
        
        Console.WriteLine("Updated inventory:");
        
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }
           
        
        Console.WriteLine($"\nTotal items in inventory: {inventory.Count}");
    }
}