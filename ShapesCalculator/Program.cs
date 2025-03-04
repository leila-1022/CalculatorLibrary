
using CalculatorLibrary;
using CalculatorLibrary.Formulas;
using CalculatorLibrary.Formulas.Shapes;
using System;

class Program
{
    static void Main()
    {
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
            Console.WriteLine("└───────────────────────┘");

            Console.Write("Enter your choice: ");

        }
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3);
        switch (choice)
        {
            case 1:

                SolveCircle();
                break;
            case 2:

                SolveRectangle();
                break;
            case 3:
                SolveSquare();
                break;
        }
        static void SolveCircle()
        {
            Console.Clear();
            Console.WriteLine("Circle Calculator\n");

            int circOption;
            do
            {
                Console.Write("Solve for the circumference using (1.Radius/2.Diameter/3.Area): ");
            }
            while (!int.TryParse(Console.ReadLine(), out circOption) || circOption < 1 || circOption > 3);

            decimal value;

            switch (circOption)
            {
                case 1:
                    Console.Write("\n Enter Radius: ");
                    if (decimal.TryParse(Console.ReadLine(), out value))
                    {
                        Circle.Radius = value;
                        Console.WriteLine(Circle.GetCircRadius());

                    }
                    break;

                case 2:
                    Console.Write("/n Enter Diameter: ");
                    if (decimal.TryParse(Console.ReadLine(), out value))
                    {
                        Circle.Diameter = value;
                        Console.WriteLine(Circle.GetCircDiameter());
                    }
                    break;

                case 3:
                    Console.Write("/n Enter Area: ");
                    if (decimal.TryParse(Console.ReadLine(), out value))
                    {
                        Circle.Area = value;
                        Console.WriteLine(Circle.GetCircArea());
                    }
                    break;
            }

            int areaOption;
            {
                do
                {
                    Console.Write("\nSolve for the area using (1.Radius / 2.Diameter / 3.Circumference): ");
                } while (!int.TryParse(Console.ReadLine(), out areaOption) || areaOption < 1 || areaOption > 3);

                switch (areaOption)
                {
                    case 1:
                        Console.Write("\nEnter Radius: ");
                        if (decimal.TryParse(Console.ReadLine(), out value))
                        {
                            Circle.Radius = value;
                            Console.WriteLine(Circle.GetAreaRadius());
                        }
                        break;
                    case 2:
                        Console.Write("\nEnter Diameter: ");
                        if (decimal.TryParse(Console.ReadLine(), out value))
                        {
                            Circle.Diameter = value;
                            Console.WriteLine(Circle.GetAreaDiameter());
                        }
                        break;
                    case 3:
                        Console.Write("\nEnter Circumference: ");
                        if (decimal.TryParse(Console.ReadLine(), out value))
                        {
                            Circle.Circumference = value;
                            Console.WriteLine(Circle.GetAreaCircumference());
                        }
                        break;
                }
            }

        }
    }
    static void SolveRectangle()
    {
        Console.Clear();
        Console.WriteLine("Rectangle Calculator\n");

        decimal length, width;
        Console.Write("Enter length: ");

        while (!decimal.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.Write("Invalid input. Enter a positive length: ");
        }

        Console.Write("Enter width: ");
        while (!decimal.TryParse(Console.ReadLine(), out width) || width <= 0)
        {
            Console.Write("Invalid input. Enter a positive width: ");
        }

        Rectangle.Length = length;
        Rectangle.Width = width;

        Console.WriteLine(Rectangle.GetRecArea());
        Console.WriteLine(Rectangle.GetRecPerimeter());


    }
    static void SolveSquare()
    {
        Console.Clear();
        Console.WriteLine("Square Calculator\n");

        decimal side;
        Console.Write("Enter side: ");
        while (!decimal.TryParse(Console.ReadLine(), out side) || side <= 0)
        {
            Console.Write("Invalid input. Enter a positive side length: ");
        }

        Square.Side = side;

        Console.WriteLine(Square.GetSquArea());
        Console.WriteLine(Square.GetSquPerimeter());
    }
}

