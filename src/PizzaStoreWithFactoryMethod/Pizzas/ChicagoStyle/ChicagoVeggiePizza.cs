using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;

namespace PizzaStoreWithFactoryMethod.Pizzas.ChicagoStyle;

public class ChicagoVeggiePizza : Pizza
{
    public ChicagoVeggiePizza()
    {
        Name = "Chicago Style Veggie Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        
        Toppings.Add("Grated Parmesan Cheese");
    }
}