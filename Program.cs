namespace ClassLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Circle biggerCircle = new Circle(6);

            Console.WriteLine($"\t\t\tArea\t\tCircumference\tVolume\n");
            Console.WriteLine($"Circle 1, Radius of {circle.Radius}:\t{circle.GetArea().ToString("F2")}\t\t{circle.GetCircumference().ToString("F2")}\t\t{circle.GetVolume().ToString("F2")}");
            Console.WriteLine($"Circle 2, radius of {biggerCircle.Radius}:\t{biggerCircle.GetArea().ToString("F2")}\t\t{biggerCircle.GetCircumference().ToString("F2")}\t\t{biggerCircle.GetVolume().ToString("F2")}");

            Triangle triangle1 = new Triangle(5, 4);

            Console.WriteLine($"\nFor the triangle calculation it is assumed that your triangle has a right angle. Base will be assumed to have a side of {triangle1.width} and a height of {triangle1.height} for the pyramid volume");
            Console.WriteLine($"\n\t\t\t\tArea\t\tPerimeter\tVolume\n");
            Console.WriteLine($"Triangle, width {triangle1.width}, height {triangle1.height}\t{triangle1.GetArea().ToString("F2")}\t\t{triangle1.GetPerimeter().ToString("F2")}\t\t{triangle1.GetPyramidVolume().ToString("F2")}");

            Console.WriteLine("\nPlease note that this program truncates to 2 decimals for ease of reding. The calculations have an exactness of up to 15 digits.");
        }
    }
}
