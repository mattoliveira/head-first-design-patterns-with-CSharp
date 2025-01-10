using Strategy.Interfaces;

namespace Strategy.Abstractions;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public abstract void Display();

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!!");
    }

    public void SetFlyBehavior(IFlyBehavior fb)
    {
        this.flyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        this.quackBehavior = qb;
    }
}