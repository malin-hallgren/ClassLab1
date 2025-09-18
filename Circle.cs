using System;
using System.Numerics;

public class Circle
{
    public int radius;

    public double GetArea()
    {
        return radius * radius * Math.PI;
    }

    public double GetCircumference()
    {
        return (radius * 2) * Math.PI;
    }

    public double GetVolume()
    {
        return (Math.Pow(radius, 3) * Math.PI) * (4.0/3.0);
    }
}
