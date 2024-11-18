using Kata7;

namespace Kata8;

class Program
{

    static void Main()
    {
        Player Arin = new Player(100,20);
        Enemy Orc = new Enemy("Orc", 10, 20);
        Arin.Attack(20, Orc);
        Orc.takeDmg(Arin._dmg);
        
        while (Player._lvl ==1)
        {
            Arin.Attack(20, Orc);
            Orc.takeDmg(Arin._dmg);
            if (Orc._isAlive == false)
            {
                Arin.GetExp(Orc.GiveExp());
            }
        }
        
        

        
        
    }
}



