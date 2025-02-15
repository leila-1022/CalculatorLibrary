using System;
using CalculatorLibrary1.Formulas;
using CalculatorLibrary1;

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("|         MAIN MENU         |");
            Console.WriteLine("|    1. Circle              |");
            Console.WriteLine("|    2. Rectangle           |");
            Console.WriteLine("|    3. Square              |");
            Console.WriteLine("|    4. Exit                |");
            Console.WriteLine("=============================");
            Console.Write("Choose a Shape: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a value for the radius: ");
                        if (double.TryParse(Console.ReadLine(), out var radius))
                        {
                            CalculatorLibrary1.Formulas.Shapes.Circle.Radius = radius;

                            Console.WriteLine($"Circle result for Area: {CalculatorLibrary1.Formulas.Shapes.Circle.Area()}");
                            Console.WriteLine($"Circle result for Circumference: {CalculatorLibrary1.Formulas.Shapes.Circle.Circumference()}");
                        }
                        else
                        {
                            Console.WriteLine("Error! Enter a Number Please!! ");
                        }
                        break;

                    case 2:
                        Console.Write("Enter a value for the Length: ");
                        if (double.TryParse(Console.ReadLine(), out var length))
                        {
                            Console.Write("Enter a value for the Width: ");
                            if (double.TryParse(Console.ReadLine(), out var width))
                            {
                                CalculatorLibrary1.Formulas.Shapes.Rectangle.Length = length;
                                CalculatorLibrary1.Formulas.Shapes.Rectangle.Width = width;

                                Console.WriteLine($"Rectangle result for Area: {CalculatorLibrary1.Formulas.Shapes.Rectangle.Area()}");
                                Console.WriteLine($"Rectangle result for Perimeter: {CalculatorLibrary1.Formulas.Shapes.Rectangle.Perimeter()}");
                            }
                            else
                            {
                                Console.WriteLine("Error! Enter a Number Please!! ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! Enter a Number Please!! ");
                        }
                        break;

                    case 3:
                        Console.Write("Enter a value for Side: ");
                        if (double.TryParse(Console.ReadLine(), out var side))
                        {
                            CalculatorLibrary1.Formulas.Shapes.Square.Side = side;

                            Console.WriteLine($"Square result for Area: {CalculatorLibrary1.Formulas.Shapes.Square.Area()}");
                            Console.WriteLine($"Square result for Perimeter: {CalculatorLibrary1.Formulas.Shapes.Square.Perimeter()}");
                        }
                        else
                        {
                            Console.WriteLine("Error! Enter a Number Please!! ");
                        }
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input! Please enter a number.");
                        break;
                }

                if (!exit)
                {
                    string Choice;
                    bool validChoice = false;

                    while (!validChoice)
                    {
                        Console.Write("Do you want to continue? (yes/no): ");
                        Choice = Console.ReadLine().Trim().ToLower();  

                        if (Choice == "yes")
                        {
                            validChoice = true;
                            exit = false; 
                        }
                        else if (Choice == "no")
                        {
                            validChoice = true;
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice! Please enter 'yes' or 'no'.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        Console.WriteLine("Exiting the program...");
    }
}
