using System;

namespace DesignPatternsInCSharp.AdapterDesignPattern;

public class SquarePegAdapter : IRoundPeg
{
    private readonly SquarePeg _squarePeg;

    public SquarePegAdapter(SquarePeg squarePeg)
    {
        _squarePeg = squarePeg;
    }

    public double GetRadius()
    {
        return _squarePeg.Width * Math.Sqrt(2) / 2;
    }
}
