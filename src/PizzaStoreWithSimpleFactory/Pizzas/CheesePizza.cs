using PizzaStoreWithSimpleFactory.Pizzas.Abstractions;

namespace PizzaStoreWithSimpleFactory.Pizzas;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Name = "Cheese Pizza";
        Dough = "Regular Crust";
        Sauce = "Marinara Pizza Sauce";

        Toppings.Add("Fresh Mozzarella");
        Toppings.Add("Parmesan");
    }
}