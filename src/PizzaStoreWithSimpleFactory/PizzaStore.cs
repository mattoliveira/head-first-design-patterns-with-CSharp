using PizzaStoreWithSimpleFactory.Factories;
using PizzaStoreWithSimpleFactory.Pizzas.Abstractions;

namespace PizzaStoreWithSimpleFactory;

public class PizzaStore
{
    private SimplePizzaFactory _factory;
    
    public PizzaStore(SimplePizzaFactory factory)
    {
        _factory = factory;
    }
    
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = _factory.CreatePizza(type);
        
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        
        return pizza;
    }
}