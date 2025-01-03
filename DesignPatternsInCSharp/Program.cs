// See https://aka.ms/new-console-template for more information
using DesignPatternsInCSharp;
using DesignPatternsInCSharp.FactoryDesignPattern;

// Factory Design Pattern
IFactory factory = new ConcreteFactory();
IProduct product = factory.CreateProduct("New Factory");
product.StateName("This is from the factory design pattern.");