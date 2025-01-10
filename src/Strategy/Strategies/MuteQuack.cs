using Strategy.Interfaces;

namespace Strategy.Strategies;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}