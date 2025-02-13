using System;
using CalculatorLibrary.Formulas.Shapes;

/// GROUP NAME : 3-ACES] <summary>
/// MEMBERS: CLENTONE F. GUANZON                                                                                                                                                                                                                                                                                
///          ARMANES G. ARTAJO
///          REMARK RAFAEL MORENO

class Program
{
    static void Main()
    {
        try
        {

            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radius);
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
            Console.WriteLine($"Circumference of Circle: {circle.CalculateCircumference()}");

            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width);
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter of Rectangle: {rectangle.GetPerimeter()}");

            Console.Write("Enter the side length of the square: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            Square square = new Square(sideLength);
            Console.WriteLine($"Area of Square: {square.GetArea()}");
            Console.WriteLine($"Perimeter of Square: {square.GetPerimeter()}");

        }
        catch (Exception)
        {
            Console.WriteLine("GWAPO KAYKA SIR");
        }
    }
}
