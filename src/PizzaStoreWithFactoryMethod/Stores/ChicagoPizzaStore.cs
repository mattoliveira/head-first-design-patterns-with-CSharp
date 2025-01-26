using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;
using PizzaStoreWithFactoryMethod.Pizzas.ChicagoStyle;

namespace PizzaStoreWithFactoryMethod.Stores;

public class ChicagoPizzaStore : Abstractions.PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type.Equals("cheese"))
        {
            return new ChicagoCheesePizza();
        }

        if (type.Equals("pepperoni"))
        {
            return new ChicagoPepperoniPizza();
        }

        if (type.Equals("clam"))
        {
            return new ChicagoClamPizza();
        }

        if (type.Equals("veggie"))
        {
            return new ChicagoVeggiePizza();
        }
        else
        {
            return null;
        }
    }
}