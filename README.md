# Head First - Design Patterns with C#
Examples from Head First - Design Patterns book implemented in C#

### Strategy Pattern
The Strategy Pattern defines a family of algorithms,
encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independently from
clients that use it.

[Example - SimUDuck](./src/Strategy/)

### Observer Pattern
The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. The Observer allows objects to subscribe and receive updates from other objects without needing to know the internal details of those objects.

There are two types of examples, one with the Observer Pattern implemented with the .NET interfaces and the other with the Observer Pattern implemented with the custom implementation.

[Example - WheaterStation Simple](./src/ObserverSimple/)

[Example - WeatherStation With .NET Interfaces ](./src/ObserverWithDotnetInterfaces/)