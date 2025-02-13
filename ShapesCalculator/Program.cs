using CalculatorLibrary;
using CalculatorLibrary.Formulas;
using CalculatorLibrary.Formulas.Shapes;
using System.Globalization;


/*
 Group Name: PDEA (Punta,Duljo,Ermita,A.Lopez)
 Group Members: Quiño, Bryan E.
                Villareal, Ivan Vincent C.
                Gulfan, James Laurence (Jaguar)
 */
Console.WriteLine(@"
  +--------------------------------+
  | Welcome To Shapes Calculator!  |
  |                                |
  |         1. Circle              |
  |         2. Square              |
  |         3. Rectangle           |
  |                                |
  +--------------------------------+");
Console.Write("Enter choice: ");
int option = int.Parse(Console.ReadLine() ?? "1");

switch (option)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Welcome To Circle Calculator!");
        Console.WriteLine("1. Calculate circumference and area using diameter");
        Console.WriteLine("2. Calculate circumference and area using radius");
        Console.Write("\nEnter choice: ");
        int choice = int.Parse(Console.ReadLine() ?? "1");

        switch (choice)
        {
            case 1:
                Console.Write("\nEnter the value of diameter: ");
                decimal.TryParse(Console.ReadLine(), out var diameter);
                decimal pi = 3.14m;

                Circle.Diameter = diameter;
                Circle.Pi = pi;

                Console.WriteLine(Circle.GetCircumferenceUsingDiameter());
                Console.WriteLine(Circle.GetAreaUsingDiameter());
                break;

            case 2:
                Console.Write("\nEnter the value of radius: ");
                decimal.TryParse(Console.ReadLine(), out var radius);
                pi = 3.14m;

                Circle.Radius = radius;
                Circle.Pi = pi;

                Console.WriteLine(Circle.GetCircumferenceUsingRadius());
                Console.WriteLine(Circle.GetAreaUsingRadius());
                break;
        }
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Welcome To Square Calculator!");
        Console.Write("Enter the value of sides: ");
        decimal.TryParse(Console.ReadLine(), out var sides);
        

        Square.Sides = sides;
        
        Console.WriteLine(Square.GetSquareArea());
        Console.WriteLine(Square.GetSquarePerimeter());


        break;

    case 3:
        Console.Clear();
        Console.WriteLine("Welcome To Rectangle Calculator!");
        Console.Write("Enter the value of length: ");
        decimal.TryParse(Console.ReadLine(), out var length);
        Console.Write("Enter the value of width: ");
        decimal.TryParse(Console.ReadLine(), out var width);


        Rectangle.Length = length;
        Rectangle.Width = width;

        Console.WriteLine(Rectangle.GetRectangleArea());
        Console.WriteLine(Rectangle.GetRectanglePerimeter());

        break;

    default:
        Console.WriteLine("Invalid choice. Please choose a valid option.");
        break;
}
