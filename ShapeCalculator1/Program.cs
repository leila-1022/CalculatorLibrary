using CalculatorLibrary;
using CalculatorLibrary.Formulas;

class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shapes Calculator!");
        Console.WriteLine("Choose a shape to calculate its area and perimeter:");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Circle");
        Console.WriteLine("3. Square");

        Console.Write("Enter your choice: ");
        string s_choice = Console.ReadLine();
        int choice = int.Parse(s_choice == null ? "0" : s_choice);

        switch (choice)
        {
            case 1:
                Console.Write("Enter the length of the rectangle: ");
                string s_length = Console.ReadLine();
                double length = double.Parse(s_length == null ? "0" : s_length);
                if (length == 0)
                {
                    Console.WriteLine("Length cannot be 0");
                    Console.ReadKey();
                    return 0;
                }
                Console.Write("Enter the width of the rectangle: ");
                string s_width = Console.ReadLine();
                double width = double.Parse(s_width == null ? "0" : s_width);
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
                string s_radius = Console.ReadLine();
                double radius = double.Parse(s_radius == null ? "0" : s_radius);
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
                string s_side = Console.ReadLine();
                double side = double.Parse(s_side == null ? "0" : s_side);
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
