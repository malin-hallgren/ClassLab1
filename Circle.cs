using System;
using System.Numerics;

public class Circle
{
    private int _radius;

    public int Radius 
    { 
        get {  return _radius; }
        set {
            if (value > 0)
            {
                _radius = value;
            }
            else
            {
                Console.WriteLine("Radius must be above 0");
            }
        }
    }
    public Circle (int radius)
    {
        Radius = radius;
    }
    


    //Defines three methods to get area, circumference and hypothetical
    //volume of the circle/sphere using radius defined in creation of Object
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
