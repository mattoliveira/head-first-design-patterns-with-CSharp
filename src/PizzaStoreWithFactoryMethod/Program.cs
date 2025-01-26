
using PizzaStoreWithFactoryMethod.Pizzas.Abstractions;
using PizzaStoreWithFactoryMethod.Stores;
using PizzaStoreWithFactoryMethod.Stores.Abstractions;

PizzaStore nyPizzaStore = new NYPizzaStore();
PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

Pizza pizza = nyPizzaStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza.Name}");

pizza = chicagoPizzaStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a pizza {pizza.Name}");