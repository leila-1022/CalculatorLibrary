using System;

class Program
{
    static void Main()
    {
        double slope = GetValidDouble("Enter slope: ");
        double intercept = GetValidDouble("Enter intercept: ");
        
        int count = GetValidInt("Enter the number of x values: ");

        double[] xValues = new double[count];

        for (int i = 0; i < count; i++)
        {
            xValues[i] = GetValidDouble($"Enter x value {i + 1}: ");
        }

        Console.WriteLine($"\ny = {slope}x + ({intercept}):");
        for (int i = 0; i < count; i++)
        {
            double y = slope * xValues[i] + intercept;
            Console.WriteLine($"For x = {xValues[i]}, y = {y}");
        }
    }

    static double GetValidDouble(string prompt)
    {
        double value;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write(prompt);
        }
        return value;
    }

    static int GetValidInt(string prompt)
    {
        int value;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write(prompt);
        }
        return value;
    }
}