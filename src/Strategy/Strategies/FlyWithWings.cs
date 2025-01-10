using Strategy.Interfaces;

namespace Strategy.Strategies;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm Flying!!");
    }
}