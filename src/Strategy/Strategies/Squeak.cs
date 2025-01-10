using Strategy.Interfaces;

namespace Strategy.Strategies;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}