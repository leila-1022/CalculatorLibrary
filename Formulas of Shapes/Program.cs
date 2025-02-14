using System;
using System.Runtime.CompilerServices;
using CalculatorLibrary;

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
                Environment.Exit(0);
                break;
            }

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine() == "" ? "0" : Console.ReadLine() ?? "0");
                    CalculatorLibrary.Formulas.Shapes.Circle.Radius = radius;
                    Console.WriteLine($"Circumference: {CalculatorLibrary.Formulas.Shapes.Circle.Circumference()}\nArea: {CalculatorLibrary.Formulas.Shapes.Circle.Area()}");
                    break;

                case "2":
                    Console.Clear();
                    Console.Write("Enter width: ");
                    double width = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Enter length: ");
                    double length = double.Parse(Console.ReadLine() ?? "0");
                    CalculatorLibrary.Formulas.Shapes.Rectangle.Width = width;
                    CalculatorLibrary.Formulas.Shapes.Rectangle.Length = length;
                    Console.WriteLine($"Area: {CalculatorLibrary.Formulas.Shapes.Rectangle.Area()}\nPerimeter: {CalculatorLibrary.Formulas.Shapes.Rectangle.Perimeter()}");
                    break;

                case "3":
                    Console.Clear();
                    Console.Write("Enter side: ");
                    double side = double.Parse(Console.ReadLine() ?? "0");
                    CalculatorLibrary.Formulas.Shapes.Square.Side = side;
                    Console.WriteLine($"Area: {CalculatorLibrary.Formulas.Shapes.Square.Area()}\nPerimeter: {CalculatorLibrary.Formulas.Shapes.Square.Perimeter()}");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}