namespace Decorator.Abstractions;

public abstract class CondimentDecorator : Beverage
{
    public abstract override string Description { get; }
}