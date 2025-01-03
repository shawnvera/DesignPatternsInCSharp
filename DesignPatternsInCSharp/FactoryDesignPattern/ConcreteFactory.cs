using System;

namespace DesignPatternsInCSharp.FactoryDesignPattern
{
    public class ConcreteFactory : IFactory
    {
        public IProduct CreateProduct(string name)
        {
            return new ConcreteProduct(name);
        }
    }
}
