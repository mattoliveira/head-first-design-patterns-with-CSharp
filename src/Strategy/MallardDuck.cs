using Strategy.Abstractions;
using Strategy.Strategies;

namespace Strategy;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehavior = new QuackImp();
        flyBehavior = new FlyWithWings();
        
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard Duck");
    }
}