using System;

namespace ExamKata10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Adventurer! What's your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine($"I'm happy you're here, {playerName}! Click to start your adventure!");

            Player player = new Player(playerName, 0);
            bool Running = true;
            Console.ReadKey();

            while (Running)
            {
                // Generate a random encounter
                Random rand = new Random();
                int encounterType = rand.Next(1, 4); // 1 = Enemy, 2 = Trader, 3 = NPC

                Console.Clear();
                switch (encounterType)
                {
                    case 1:
                        Running = EnemyEncounter(player, rand, Running);
                        break;

                    case 2: 
                        NpcEncounter(player);
                        break;

                    case 3: 
                        TraderEncounter(player);
                        break;

                    default:
                        Console.WriteLine("Something unexpected happened...");
                        break;
                }

                // Option to exit game after encounters
                Console.WriteLine("-=-=-=-=-=-=-\n* 1. Continue Adventure\n* 2. Exit Game\n-=-=-=-=-=-=-");
                string mainChoice = Console.ReadLine();
                if (mainChoice == "2")
                {
                    Console.WriteLine("Thank you for playing! Goodbye!");
                    Running = false;
                }
            }
        }

        private static void TraderEncounter(Player Arin)
        {
            Merchant trader = new Merchant("Trader");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You encounter a Trader.");
            Console.ResetColor();
            Console.WriteLine("You meet a friendly trader with wares to sell.");
            Console.WriteLine("\nWhat do you want to buy?\n1. Sword\n2. Shield\n3. Potion");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You just bought a sword!");
                    break;
                case "2":
                    Console.WriteLine("You just bought a shield!");
                    break;
                case "3":
                    Console.WriteLine("You just bought a potion!");
                    Arin.Heal(5);
                    break;
                case "4":
                    Console.WriteLine("You leave the trader.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }

        private static void NpcEncounter(Player Arin)
        {
            Npc Villager = new Npc("Villager");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You encounter a friendly villager.");
            Console.ResetColor();
            Villager.Speak("Welcome to the forest, traveler! Be careful out there!");
            Console.WriteLine("The villager gives you a small gift: 10 EXP!");
            Arin.GainExperience(10);
        }

        private static bool EnemyEncounter(Player player, Random rand, bool Running)
        {
            Enemy enemy = new Enemy("Goblin", 30, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You encounter a monster!");
            Console.ResetColor();
            Console.WriteLine($"A wild {enemy.Name} appears with {enemy.Health} health!");

            while (enemy.Health > 0 && player.Health > 0)
            {
                Console.WriteLine("-=-=-=-=-=-=-\n* 1. Attack\n* 2. Heal\n* 3. Info\n* 4. Run\n-=-=-=-=-=-=-");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // Attack
                        Console.Clear();
                        player.Attack(enemy);
                        if (enemy.Health > 0)
                        {
                            enemy.Attack(player);
                        }
                        else
                        {
                            Console.WriteLine($"You defeated the {enemy.Name}!\n you gain 20 exp!");
                            player.GainExperience(20);
                        }
                        Console.ReadKey();
                        break;

                    case "2": // Heal
                        Console.Clear();
                        int healAmount = rand.Next(10, 20);
                        player.Heal(healAmount);
                        break;

                    case "3": // Info
                        Console.Clear();
                        Console.WriteLine($"Your HP: {player.Health}\nEnemy HP: {enemy.Health}");
                        Console.ReadKey();
                        break;

                    case "4": // Run
                        Console.Clear();
                        Console.WriteLine("You escaped the battle!");
                        Console.ReadKey();
                        return Running; // Exit the encounter loop

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                if (player.Health <= 0)
                {
                    Console.WriteLine("You have been defeated. Game over!");
                    Running = false;
                    break;
                }
            }

            return Running;
        }
    }
}
