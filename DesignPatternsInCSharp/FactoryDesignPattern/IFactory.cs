using System;

namespace DesignPatternsInCSharp.FactoryDesignPattern
{
    public interface IFactory
    {
        IProduct CreateProduct(string name);
    }
}
