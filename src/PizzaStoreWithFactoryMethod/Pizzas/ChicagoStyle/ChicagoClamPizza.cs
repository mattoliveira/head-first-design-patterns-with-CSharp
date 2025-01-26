using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;

namespace PizzaStoreWithFactoryMethod.Pizzas.ChicagoStyle;

public class ChicagoClamPizza : Pizza
{
    public ChicagoClamPizza()
    {
        Name = "Chicago Style Clam Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        
        Toppings.Add("Shredded Mozzarella Cheese");
    }
}