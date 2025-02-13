using CalculatorLibrary;
using CalculatorLibrary.Formulas;

class Program
{
    static int Main(string[] args)
    {
        //repushing
        Console.WriteLine("Welcome to the Shapes Calculator!");
        Console.WriteLine("Choose a shape to calculate its area and perimeter:");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Circle");
        Console.WriteLine("3. Square");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine() ?? "0");

        switch (choice)
        {
            case 1:
                Console.Write("Enter the length of the rectangle: ");
                double length = double.Parse(Console.ReadLine() ?? "0");
                if (length == 0)
                {
                    Console.WriteLine("Length cannot be 0");
                    Console.ReadKey();
                    return 0;
                }
                Console.Write("Enter the width of the rectangle: ");
                double width = double.Parse(Console.ReadLine() ?? "0");
                if (width == 0)
                {
                    Console.WriteLine("Width cannot be 0");
                    Console.ReadKey();
                    return 0;
                }
                Console.WriteLine($"The area of the rectangle is {CalculatorLibrary.Formulas.Shapes.Rectangle.Area(length, width)}");
                Console.WriteLine($"The perimeter of the rectangle is {CalculatorLibrary.Formulas.Shapes.Rectangle.Perimeter(length, width)}");
                break;
            case 2:
                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine() ?? "0");
                if (radius == 0)
                {
                    Console.WriteLine("Radius cannot be 0");
                    Console.ReadKey();
                    return 0;
                }
                Console.WriteLine($"The circumference of the circle is {CalculatorLibrary.Formulas.Shapes.Circle.Circumference(radius)}");
                Console.WriteLine($"The area of the circle is {CalculatorLibrary.Formulas.Shapes.Circle.Area(radius)}");
                break;
            case 3:
                Console.Write("Enter the side of the square: ");
                double side = double.Parse(Console.ReadLine() ?? "0");
                if (side == 0)
                {
                    Console.WriteLine("Side cannot be 0");
                    Console.ReadKey();
                    return 0;
                }
                Console.WriteLine($"The area of the square is {CalculatorLibrary.Formulas.Shapes.Square.Area(side)}");
                Console.WriteLine($"The perimeter of the square is {CalculatorLibrary.Formulas.Shapes.Square.Perimeter(side)}");
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                break;
        }
        return 0;
    }
}
