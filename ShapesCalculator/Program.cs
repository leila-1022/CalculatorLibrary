/// GROUP NAME : 3-ACES
/// MEMBERS: CLENTONE F. GUANZON                                                                                                                                                                                                                                                                                
///          ARMANES G. ARTAJO
///          RIMARK RAFAEL MORENO

using System;
using CalculatorLibrary.Formulas.Shapes;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("║        SHAPE CALCULATOR       ║");
            Console.WriteLine("╠═══════════════════════════════╣");
            Console.WriteLine("║ 1. Circle                     ║");
            Console.WriteLine("║ 2. Rectangle                  ║");
            Console.WriteLine("║ 3. Square                     ║");
            Console.WriteLine("║ 4. Exit                       ║");
            Console.WriteLine("╚═══════════════════════════════╝");
            Console.Write("Choose an option: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the radius of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());

                        Circle circle = new Circle(radius);
                        Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
                        Console.WriteLine($"Circumference of Circle: {circle.CalculateCircumference()}");
                        break;

                    case 2:
                        Console.Write("Enter the length of the rectangle: ");
                        double length = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the width of the rectangle: ");
                        double width = Convert.ToDouble(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(length, width);
                        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");
                        Console.WriteLine($"Perimeter of Rectangle: {rectangle.GetPerimeter()}");
                        break;

                    case 3:
                        Console.Write("Enter the side length of the square: ");
                        double sideLength = Convert.ToDouble(Console.ReadLine());

                        Square square = new Square(sideLength);
                        Console.WriteLine($"Area of Square: {square.GetArea()}");
                        Console.WriteLine($"Perimeter of Square: {square.GetPerimeter()}");
                        break;

                    case 4:
                        Console.WriteLine("Exiting progra" +
                            "m...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("GWAPO KAYKA SIR");
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}