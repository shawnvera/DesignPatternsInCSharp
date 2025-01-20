using System;

namespace DesignPatternsInCSharp.AdapterDesignPattern;

public class RoundPeg : IRoundPeg
{
    private double _radius;

    public RoundPeg(double radius){
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }
}
