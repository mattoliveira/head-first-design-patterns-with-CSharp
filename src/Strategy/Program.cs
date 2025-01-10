using Strategy;
using Strategy.Abstractions;
using Strategy.Strategies;

Duck mallard = new MallardDuck();
mallard.PerformQuack();
mallard.PerformFly();

Duck model = new ModelDuck();
model.PerformFly();
model.SetFlyBehavior(new FlyRocketPowered());
model.PerformFly();