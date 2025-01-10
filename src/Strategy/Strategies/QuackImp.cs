using Strategy.Interfaces;

namespace Strategy.Strategies;

public class QuackImp : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}