namespace Kata9;

public class Enemy
{
    private string _type;
    private int _dmg;
    private int _hp;


    public bool _isAlive = true;

    public Enemy(string type, int dmg, int hp)
    {
        _type = type;
        _dmg = dmg;
        _hp = hp;
    }

    public void takeDmg(int damage)
    {
        _hp -= damage;
        Console.WriteLine();

        if (_hp <= 0)
        {
            Console.WriteLine($"{_type} is dead!");
            _isAlive = false;
        }
    }
}