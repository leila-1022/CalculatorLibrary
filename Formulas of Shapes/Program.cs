using System;
using System.Runtime.CompilerServices;
using CalculatorLibrary;

/*
    Group Name: 3Idyots
    Group Members:
    Syllanto, Mary Jocelyn
    Tajanlangit, Maverick
    Verano, Kierstien
 */
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("| Welcome to Shapes Calculator! |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("| 1. Circle                     |");
            Console.WriteLine("| 2. Rectangle                  |");
            Console.WriteLine("| 3. Square                     |");
            Console.WriteLine("| 4. Exit                       |");
            Console.WriteLine("+-------------------------------+");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine() ?? "";

            if (choice == "4")
            {
                Console.WriteLine("Goodbye and Thank You For Using!");
                break;
            }

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    double radius;
                    Console.Write("Enter radius: ");
                    while (!double.TryParse(Console.ReadLine(), out radius))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for radius.");
                        Console.Write("Enter radius: ");
                    }
                    CalculatorLibrary.Formulas.Shapes.Circle.Radius = radius;
                    Console.WriteLine($"Circumference: {CalculatorLibrary.Formulas.Shapes.Circle.Circumference()}\nArea: {CalculatorLibrary.Formulas.Shapes.Circle.Area()}");
                    break;

                case "2":
                    Console.Clear();
                    double width, length;
                    Console.Write("Enter width: ");
                    while (!double.TryParse(Console.ReadLine(), out width))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for width.");
                        Console.Write("Enter width: ");
                    }

                    Console.Write("Enter length: ");
                    while (!double.TryParse(Console.ReadLine(), out length))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for length.");
                        Console.Write("Enter length: ");
                    }

                    CalculatorLibrary.Formulas.Shapes.Rectangle.Width = width;
                    CalculatorLibrary.Formulas.Shapes.Rectangle.Length = length;
                    Console.WriteLine($"Area: {CalculatorLibrary.Formulas.Shapes.Rectangle.Area()}\nPerimeter: {CalculatorLibrary.Formulas.Shapes.Rectangle.Perimeter()}");
                    break;

                case "3":
                    Console.Clear();
                    double side;
                    Console.Write("Enter side: ");
                    while (!double.TryParse(Console.ReadLine(), out side))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for side.");
                        Console.Write("Enter side: ");
                    }
                    CalculatorLibrary.Formulas.Shapes.Square.Side = side;
                    Console.WriteLine($"Area: {CalculatorLibrary.Formulas.Shapes.Square.Area()}\nPerimeter: {CalculatorLibrary.Formulas.Shapes.Square.Perimeter()}");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
        }
    }
}