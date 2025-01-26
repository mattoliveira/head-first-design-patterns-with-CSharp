using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;

namespace PizzaStoreWithFactoryMethod.Pizzas.ChicagoStyle;

public class ChicagoCheesePizza : Pizza
{
    public ChicagoCheesePizza()
    {
        Name = "Chicago Style Deep Dish Cheese Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Toppings.Add("Shredded Mozzarella Cheese");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}