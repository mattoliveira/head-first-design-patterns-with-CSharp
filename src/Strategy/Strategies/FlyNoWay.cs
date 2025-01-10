using Strategy.Interfaces;

namespace Strategy.Strategies;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}