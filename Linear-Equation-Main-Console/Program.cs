using System;
using CalculatorLibrary.Formulas.Linear_Equation;

class Program
{
    public static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter slope: ");
                double slope = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter intercept: ");
                double intercept = Convert.ToDouble(Console.ReadLine());

                var equation = new LinearEquation(slope, intercept);

                Console.Write("Enter x value: ");
                double x = Convert.ToDouble(Console.ReadLine());

                double y = equation.CalculateY(x);
                Console.WriteLine($"The value of y for x = {x} is: {y}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.Write("Do you want to try again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                break;
            }
        }
    }
}
