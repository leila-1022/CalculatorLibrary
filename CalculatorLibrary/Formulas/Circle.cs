using System;

public class Circle
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(radius);

        Console.WriteLine("Area: " + circle.GetArea());
        Console.WriteLine("Circumference: " + circle.GetCircumference());
    }
}
