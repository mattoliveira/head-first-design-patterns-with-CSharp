using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;

namespace PizzaStoreWithFactoryMethod.Pizzas.NyStyle;

public class NYPepperoniPizza : Pizza
{
    public NYPepperoniPizza()
    {
        Name = "NY Style Peperroni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        
        Toppings.Add("Grated Reggiano Cheese");
    }
}