namespace ClassLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates two new objects of class circle with specified radius
            Circle circle = new Circle { radius = 5};
            Circle biggerCircle = new Circle { radius = 6};

            //Runs three mathematical methods per object, and displays the result as
            //a string to limit them to two decimals for readability.
            //Formats the output to look like a nice little table
            Console.WriteLine($"\t\t\tArea\t\tCircumference\tVolume\n");
            Console.WriteLine($"Circle 1, Radius of {circle.radius}:\t{circle.GetArea().ToString("F2")}\t\t{circle.GetCircumference().ToString("F2")}\t\t{circle.GetVolume().ToString("F2")}");
            Console.WriteLine($"Circle 2, radius of {biggerCircle.radius}:\t{biggerCircle.GetArea().ToString("F2")}\t\t{biggerCircle.GetCircumference().ToString("F2")}\t\t{biggerCircle.GetVolume().ToString("F2")}");

            //Creates a new Triangle object with specified height and width
            Triangle triangle1 = new Triangle { height = 5, width = 4};

            //Informs the user of what assumptions are made about the triangle 
            //for calculations to work, displays result of the three methods
            //and formats output into nice table for better readability
            Console.WriteLine($"\nFor the triangle calculation it is assumed that your triangle has a right angle. Base will be assumed to have a side of {triangle1.width} and a height of {triangle1.height} for the pyramid volume");
            Console.WriteLine($"\n\t\t\t\tArea\t\tPerimeter\tVolume\n");
            Console.WriteLine($"Triangle, width {triangle1.width}, height {triangle1.height}\t{triangle1.GetArea().ToString("F2")}\t\t{triangle1.GetPerimeter().ToString("F2")}\t\t{triangle1.GetPyramidVolume().ToString("F2")}");

            //Prints disclaimer about accuracy to the user
            Console.WriteLine("\nPlease note that this program truncates to 2 decimals for ease of reding. The calculations have an exactness of up to 15 digits.");
        }
    }
}
