using PizzaStoreWithSimpleFactory.Pizzas;
using PizzaStoreWithSimpleFactory.Pizzas.Abstractions;

namespace PizzaStoreWithSimpleFactory.Factories;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        
        if (type.Equals("cheese"))
        {
            pizza = new CheesePizza();
        }
        else if (type.Equals("pepperoni"))
        {
            pizza = new PepperoniPizza();
        }
        else if (type.Equals("clam"))
        {
            pizza = new ClamPizza();
        }
        else if (type.Equals("veggie"))
        {
            pizza = new VeggiePizza();
        }

        return pizza;
    }
}