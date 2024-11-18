namespace MiniKata6;

class Program
{
    
    
    
    static void Main(string[] args)
    {
        string[] mobs = { "Goblin", "Orc", "Troll \n" };
        
        Console.WriteLine("Enemies:");
        for (int i = 0; i < mobs.Length; i++)
        {
            
            Console.WriteLine(mobs[i]);
        }
        
        string[] inventory = { "Shield", "Sword", "Potions \n" };
        Console.WriteLine("Inventory:");
        for (int i = 0; i < inventory.Length; i++)
        {
            
            Console.WriteLine(inventory[i]);
        }
        Console.WriteLine("Updated inventory:");
        string[] updinventory = { "Shield", "Sword", "Potions", "Helmet" };
        {
            for (int i = 0; i < updinventory.Length; i++)
            {
                Console.WriteLine(updinventory[i]);
            }
        }
        
        
       
        
            
        
        
        
        
    }
}