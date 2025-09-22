using System;

public class Triangle
{
	public int height {  get; set; }
	public int width{ get; set; }

	public Triangle (int height, int width)
	{
		this.height = height;
		this.width = width;
	}

	//Defines three mathematical methods to calculate area, perimeter
	//and hypothetical volume of a triangle/pyramid, using width and height
	//passed to instance of class upon creation of object.
	public double GetArea()
	{
		return (height * width)/2;
	}

	public double GetPerimeter()
	{
		double hypotenuse = Math.Sqrt((Math.Pow(width, 2) + Math.Pow(height, 2)));
        return hypotenuse + width + height;
	}

	public double GetPyramidVolume()
	{
        return Math.Pow(width, 2) * height * (1.0/3.0);
	}
}
