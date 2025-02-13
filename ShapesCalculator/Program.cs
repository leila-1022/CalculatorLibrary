/*
Group WaKoKabaw
Members:
    Sucgang
    Cabaluna
    Evangelista
*/
using CalculatorLibrary.Formulas.Shapes;
using System;

Console.Write("*********************");
Console.Write("*                   *");
Console.Write("* Shapes Calculator *");
Console.Write("* 1. Circle         *");
Console.Write("* 2. Square         *");
Console.Write("* 3. Rectangle      *");
Console.Write("*                   *");
Console.Write("*********************");
Console.Write("shape to select(1-3): ");
try
{
    int choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (choice)
    {
        case 1:
            Console.Write("radius: ");
            Circle.radius = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("************************");
            Console.Write("*                      *");
            Console.Write("* Circle Calculator    *");
            Console.Write("* 1. get Area          *");
            Console.Write("* 2. get Circumference *");
            Console.Write("*                      *");
            Console.Write("************************");
            Console.Write("get circle properties(1-2): ");
            int choiceFunc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (choiceFunc)
            {
                case 1:
                    Console.WriteLine($"area of the circle is {Circle.getArea()}");
                    break;
                case 2:
                    Console.WriteLine($"circumference of the circle is {Circle.getCircumference()}");
                    break;
                default:
                    Console.WriteLine("Unknown property given");
                    break;
            }
            break;
        case 2:
            Console.Write("side length: ");
            Square.sideLength = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("*********************");
            Console.Write("*                   *");
            Console.Write("* Square Calculator *");
            Console.Write("* 1. get Area       *");
            Console.Write("* 2. get Perimeter  *");
            Console.Write("*                   *");
            Console.Write("*********************");
            Console.Write("get square properties(1-2): ");
            int choiceFunc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (choiceFunc)
            {
                case 1:
                    Console.WriteLine($"area of the circle is {Square.getArea()}");
                    break;
                case 2:
                    Console.WriteLine($"perimeter of the circle is {Square.getPerimeter()}");
                    break;
                default:
                    Console.WriteLine("Unknown property given");
                    break;
            }
            break;
        case 3:
            Console.Write("height: ");
            Rectangle.height = Convert.ToDouble(Console.ReadLine());
            Console.Write("width: ");
            Rectangle.width = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("************************");
            Console.Write("*                      *");
            Console.Write("* Rectangle Calculator *");
            Console.Write("* 1. get Area          *");
            Console.Write("* 2. get Perimeter     *");
            Console.Write("*                      *");
            Console.Write("************************");
            Console.Write("get rectangle properties(1-2): ");
            int choiceFunc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (choiceFunc)
            {
                case 1:
                    Console.WriteLine($"area of the circle is {Rectangle.getArea()}");
                    break;
                case 2:
                    Console.WriteLine($"perimeter of the circle is {Rectangle.getPerimeter()}");
                    break;
                default:
                    Console.WriteLine("Unknown property given");
                    break;
            }
            break;
        default:
            Console.WriteLine("Unknown shape given");
            break;
    }
}
catch { }