using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;

namespace PizzaStoreWithFactoryMethod.Pizzas.NyStyle;

public class NYVeggiePizza : Pizza
{
    public NYVeggiePizza()
    {
        Name = "NY Style Veggie Pizza";
        Dough = "Thin crust";
        Sauce = "Marinara sauce";
        
        Toppings.Add("Grated Reggiano Cheese");
    }
}