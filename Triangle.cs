using System;

public class Triangle
{
	//using auto-properties here
	public int Height {  get; set; }
	public int Width{ get; set; }

	public Triangle (int height, int width)
	{
		Height = height;
		Width = width;
	}

	//Defines three mathematical methods to calculate area, perimeter
	//and hypothetical volume of a triangle/pyramid, using width and height
	//passed to instance of class upon creation of object.
	public double GetArea()
	{
		return (Height * Width) /2;
	}

	public double GetPerimeter()
	{
		double hypotenuse = Math.Sqrt((Math.Pow(Width, 2) + Math.Pow(Height, 2)));
        return hypotenuse + Width + Height;
	}

	public double GetPyramidVolume()
	{
        return Math.Pow(Width, 2) * Height * (1.0/3.0);
	}
}
