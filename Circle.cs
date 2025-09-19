using System;
using System.Numerics;

public class Circle
{
    public int radius;


    //Defines three methods to get area, circumference and hypothetical
    //volume of the circle/sphere using radius defined in creation of Object
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
