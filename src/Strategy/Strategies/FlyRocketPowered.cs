using Strategy.Interfaces;

namespace Strategy.Strategies;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm Flying with a rocket!");
    }
}