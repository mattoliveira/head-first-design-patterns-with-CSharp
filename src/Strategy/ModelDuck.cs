using Strategy.Abstractions;
using Strategy.Strategies;

namespace Strategy;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new QuackImp();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}