using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;
using PizzaStoreWithFactoryMethod.Pizzas.NyStyle;

namespace PizzaStoreWithFactoryMethod.Stores;

public class NYPizzaStore : Abstractions.PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type.Equals("cheese"))
        {
            return new NYCheesePizza();
        }

        if (type.Equals("pepperoni"))
        {
            return new NYPepperoniPizza();
        }

        if (type.Equals("clam"))
        {
            return new NYClamPizza();
        }

        if (type.Equals("veggie"))
        {
            return new NYVeggiePizza();
        }
        else
        {
            return null;
        }
    }
}