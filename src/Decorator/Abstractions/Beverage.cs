namespace Decorator.Abstractions;

public abstract class Beverage
{
    public virtual string Description { get; protected set; } = "Unknown Beverage";
    public abstract double Cost();
    
}