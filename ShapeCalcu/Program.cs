using CalculatorLibrary;
using CalculatorLibrary.Formulas.Shapes;
using System;

namespace ShapesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n" + new string('=', 30));
                Console.WriteLine("|      SHAPE CALCULATOR      |");
                Console.WriteLine(new string('=', 30));
                Console.WriteLine("|  1. Circle                |");
                Console.WriteLine("|  2. Rectangle             |");
                Console.WriteLine("|  3. Square                |");
                Console.WriteLine("|  4. Exit                  |");
                Console.WriteLine(new string('=', 30));
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter radius: ");
                        if (double.TryParse(Console.ReadLine(), out double radius))
                        {
                            Console.WriteLine($"Circumference: {Circle.CalculateCircumference(radius)}");
                            Console.WriteLine($"Diameter: {Circle.CalculateDiameter(radius)}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter height: ");
                        if (double.TryParse(Console.ReadLine(), out double height))
                        {
                            Console.Write("Enter width: ");
                            if (double.TryParse(Console.ReadLine(), out double width))
                            {
                                Console.WriteLine($"Rectangle Area: {Rectangle.CalculateArea(height, width)}");
                                Console.WriteLine($"Rectangle Perimeter: {Rectangle.CalculatePerimeter(height, width)}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter side length: ");
                        if (double.TryParse(Console.ReadLine(), out double side))
                        {
                            Console.WriteLine($"Square Area: {Square.CalculateArea(side)}");
                            Console.WriteLine($"Square Perimeter: {Square.CalculatePerimeter(side)}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
