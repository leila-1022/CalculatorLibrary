using CalculatorLibrary;
using CalculatorLibrary.Formulas;
using CalculatorLibrary.Formulas.Shapes;
using System.Xml.Serialization;

int choice;
do
{
    Console.Clear();
    Console.WriteLine("┌───────────────────────┐");
    Console.WriteLine("│    Choose a shape     │");
    Console.WriteLine("├───────────────────────┤");
    Console.WriteLine("│  1. Circle            │");
    Console.WriteLine("│  2. Rectangle         │");
    Console.WriteLine("│  3. Square            │");
    Console.WriteLine("│  4. Exit              │");
    Console.WriteLine("└───────────────────────┘");

    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine() ?? "0");
} while (choice < 1 || choice > 3);

switch (choice) 
{
    case 1:
        do
        {
            Console.Clear();
            Console.WriteLine("Circle Calculator\n");
            int option = 0;
            do
            {
                Console.Write("Solve for the circumference of the circle using (1.Radius/2.Diameter/3.Area): ");
                option = int.Parse(Console.ReadLine() ?? "0");
            } while (option < 1 || option > 3);
            switch (option)
            {
                case 1:
                    Console.Write("\nEnter Radius: ");
                    decimal.TryParse(Console.ReadLine(), out var radius);
                    Circle.Radius = radius;
                    Console.WriteLine(Circle.GetCircRadius());
                    break;
                case 2:
                    Console.Write("\nEnter Diameter: ");
                    decimal.TryParse(Console.ReadLine(), out var diameter);
                    Circle.Diameter = diameter;
                    Console.WriteLine(Circle.GetCircDiameter());
                    break;
                case 3:
                    Console.Write("\nEnter Area: ");
                    decimal.TryParse(Console.ReadLine(), out var area);
                    Circle.Area = area;
                    Console.WriteLine(Circle.GetCircArea());
                    break;
            }
            do
            {
                Console.Write("\nSolve for the area of the circle using (1.Radius/2.Diameter/3.Area): ");
                option = int.Parse(Console.ReadLine() ?? "0");
            } while (option < 1 || option > 3);
            switch (option)
            {
                case 1:
                    Console.Write("\nEnter Radius: ");
                    decimal.TryParse(Console.ReadLine(), out var radius);
                    Circle.Radius = radius;
                    Console.WriteLine(Circle.GetAreaRadius());
                    break;
                case 2:
                    Console.Write("\nEnter Diameter: ");
                    decimal.TryParse(Console.ReadLine(), out var diameter);
                    Circle.Diameter = diameter;
                    Console.WriteLine(Circle.GetAreaDiameter());
                    break;
                case 3:
                    Console.Write("\nEnter Circumference: ");
                    decimal.TryParse(Console.ReadLine(), out var circumference);
                    Circle.Circumference = circumference;
                    Console.WriteLine(Circle.GetAreaCircumference());
                    break;
            }
        } while (AskToTryAgain());
    break;

    case 2:
        Console.Clear();
        Console.WriteLine("Rectangle Calculator\n");

        Console.Write("Enter length: ");
        decimal.TryParse(Console.ReadLine(), out var length);
        Console.Write("\nEnter width: ");
        decimal.TryParse(Console.ReadLine(), out var width);

        Rectangle.Length = length;
        Rectangle.Width = width;

        Console.WriteLine(Rectangle.GetRecArea());
        Console.WriteLine(Rectangle.GetRecPerimeter());
        AskToTryAgain();
    break;

    case 3:
        Console.Clear();
        Console.WriteLine("Square Calculator\n");

        Console.Write("Enter side: ");
        decimal.TryParse(Console.ReadLine(), out var side);

        Square.Side = side;
        
        Console.WriteLine(Square.GetSquArea());
        Console.WriteLine(Square.GetSquPerimeter());
        AskToTryAgain();
    break;
    default:
    break;

}

static bool AskToTryAgain()
{
    string? tryagain;
    do
    {
        Console.Write("\n\nDo you want to try again? (y/n): ");
        tryagain = Console.ReadLine()?.ToLower();

        if (tryagain == "y")
        {
            return true;
        }
        else if (tryagain == "n")
        {
            Console.Clear();
            Console.Write("Salamat sa Lahat\n");
            return false;
        }
        else
        {
            Console.Write("Invalid choice. Please enter 'y' or 'n'.");
        }
    } while (true);
}