using System;
using System.Numerics;

public class Circle
{
    public int Radius { get; set; }
    public Circle (int radius)
    {
        this.Radius = radius;
    }
    

    public double GetArea()
    {
        return Radius * Radius * Math.PI;
    }

    public double GetCircumference()
    {
        return (Radius * 2) * Math.PI;
    }

    public double GetVolume()
    {
        return (Math.Pow(Radius, 3) * Math.PI) * (4.0/3.0);
    }
}
