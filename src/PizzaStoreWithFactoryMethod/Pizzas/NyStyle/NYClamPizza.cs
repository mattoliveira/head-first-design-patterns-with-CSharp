using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;

namespace PizzaStoreWithFactoryMethod.Pizzas.NyStyle;

public class NYClamPizza : Pizza
{
    public NYClamPizza()
    {
        Name = "NY Style Clam Pizza";
        Dough = "Thin crust";
        Sauce = "White garlic sauce";
        
        Toppings.Add("Clams");
    }
}