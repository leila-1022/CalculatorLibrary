using System;
using LinearEquationFormula;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value for slope: ");
        double slope = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter value for intercept: ");
        double intercept = Convert.ToDouble(Console.ReadLine());


        LinearEquation equation = new LinearEquation(slope, intercept);

        Console.WriteLine("Enter value for x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y = equation.CalculateY(x);
        Console.WriteLine($"The value of y for x = {x} is: {y}");

    }
}