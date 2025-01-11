using System;

namespace DesignPatternsInCSharp.DependencyInjectionDesignPattern;

public interface IAnimal
{
    string Name { get; }
    public void MakeNoise();
}
