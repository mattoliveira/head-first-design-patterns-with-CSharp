using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;

namespace PizzaStoreWithFactoryMethod.Pizzas.ChicagoStyle;

public class ChicagoPepperoniPizza : Pizza
{
    public ChicagoPepperoniPizza()
    {
        Name = "Chicago Style Pepperoni Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        
        Toppings.Add("Shredded Mozzarella Cheese");
    }
    
}