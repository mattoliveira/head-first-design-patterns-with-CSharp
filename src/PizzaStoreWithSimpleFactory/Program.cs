
using PizzaStoreWithSimpleFactory;
using PizzaStoreWithSimpleFactory.Factories;

PizzaStore pizzaStore = new(new SimplePizzaFactory());

pizzaStore.OrderPizza("cheese");
pizzaStore.OrderPizza("pepperoni");
pizzaStore.OrderPizza("clam");
pizzaStore.OrderPizza("veggie");