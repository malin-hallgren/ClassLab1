namespace ClassLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates Circle with specified radius
            Circle circle = new Circle(5);
            Circle biggerCircle = new Circle(6);
            Circle smallerCircle = new Circle(-1);

            //Runs three mathematical methods per object, and displays the result as
            //a string to limit them to two decimals for readability.
            //Formats the output to look like a nice little table
            Console.WriteLine($"\t\t\tArea\t\tCircumference\tVolume\n");
            Console.WriteLine($"Circle 1, Radius of {circle.Radius}:\t{circle.GetArea().ToString("F2")}\t\t{circle.GetCircumference().ToString("F2")}\t\t{circle.GetVolume().ToString("F2")}");
            Console.WriteLine($"Circle 2, radius of {biggerCircle.Radius}:\t{biggerCircle.GetArea().ToString("F2")}\t\t{biggerCircle.GetCircumference().ToString("F2")}\t\t{biggerCircle.GetVolume().ToString("F2")}");

            //Creates Triangle with specified height and width
            Triangle triangle1 = new Triangle(5, 4);

            //Informs the user of what assumptions are made about the triangle 
            //for calculations to work, displays result of the three methods
            //and formats output into nice table for better readability
            Console.WriteLine($"\nFor the triangle calculation it is assumed that your triangle has a right angle. Base will be assumed to have a side of {triangle1.Width} and a height of {triangle1.Height} for the pyramid volume");
            Console.WriteLine($"\n\t\t\t\tArea\t\tPerimeter\tVolume\n");
            Console.WriteLine($"Triangle, width {triangle1.Width}, height {triangle1.Height}\t{triangle1.GetArea().ToString("F2")}\t\t{triangle1.GetPerimeter().ToString("F2")}\t\t{triangle1.GetPyramidVolume().ToString("F2")}");

            //Prints disclaimer about accuracy to the user
            Console.WriteLine("\nPlease note that this program truncates to 2 decimals for ease of reding. The calculations have an exactness of up to 15 digits.");
        }
    }
}
