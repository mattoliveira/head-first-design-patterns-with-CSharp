﻿// See https://aka.ms/new-console-template for more information

using Decorator;
using Decorator.Abstractions;
using Decorator.Condiments;

Beverage beverage = new Espresso();
Console.WriteLine($"{beverage.Description} ${beverage.Cost()}");

Beverage beverage2 = new DarkRoast();
beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);
Console.WriteLine($"{beverage2.Description} ${beverage2.Cost()}");

Beverage beverage3 = new HouseBlend();
beverage3 = new Soy(beverage3);
beverage3 = new Mocha(beverage3);
beverage3 = new Whip(beverage3);
Console.WriteLine($"{beverage3.Description} ${beverage3.Cost()}");