// See https://aka.ms/new-console-template for more information
using DesignPatternsInCSharp;
using DesignPatternsInCSharp.AdapterDesignPattern;
using DesignPatternsInCSharp.DependencyInjectionDesignPattern;
using DesignPatternsInCSharp.FactoryDesignPattern;

// Factory Design Pattern
IFactory factory = new ConcreteFactory();
IProduct product = factory.CreateProduct("New Factory");
product.StateName("This is from the factory design pattern.");

// Dependency Injection Design Pattern
Dog dog= new Dog("Girl");
dog.MakeNoise();

// Adapter Design Pattern
// Round peg
IRoundPeg roundPeg = new RoundPeg(5);
Console.WriteLine($"RoundPeg radius: {roundPeg.GetRadius()}");

// Square peg
SquarePeg squarePeg = new SquarePeg(7);
IRoundPeg adapter = new SquarePegAdapter(squarePeg);
Console.WriteLine($"SquarePeg adapted radius: {adapter.GetRadius()}");