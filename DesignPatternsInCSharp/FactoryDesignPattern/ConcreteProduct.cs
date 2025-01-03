using System;
using DesignPatternsInCSharp.FactoryDesignPattern;

namespace DesignPatternsInCSharp.FactoryDesignPattern
{
    public class ConcreteProduct : IProduct
    {
        public ConcreteProduct(string name)
        {
         
        }
        public void StateName(string name)
        {
            Console.WriteLine(name);
        }
    }
}
