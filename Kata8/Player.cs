namespace Kata7;

public class Player
{
    private int _health;
    public int _dmg { get; private set; }
    private int _exp;
    public static int _lvl = 1;
    private int _expTreshold = 100;

    public Player(int health, int dmg)
    {
        _health = health;
        _dmg = dmg;

    }

    public void Attack(int dmg, Enemy target)
    {
        _health -= dmg;
        
        Console.WriteLine($"You attacked a enemy for {dmg} damage");
        

    }

    public void GetExp(int exp)
    {
        _exp += exp;
       
        if (_exp >= _expTreshold)
        {
            LevelUp();
        }
        
    }

    void LevelUp()
    {
            _lvl ++;
            Console.WriteLine($"Player leveled to {_lvl} lvl");
    }
}


