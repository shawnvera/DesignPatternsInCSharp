using System;

namespace DesignPatternsInCSharp.DependencyInjectionDesignPattern;

public class Dog:IAnimal
{
    public string Name { get; set;}

    public Dog(string name)
    {
        Name = name;
    }

    public void MakeNoise(){
        Console.WriteLine($"{Name} is barking from the Dependency Injection Design Pattern!");
    }
}
