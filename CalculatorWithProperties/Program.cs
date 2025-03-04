using System;
using CalculatorLibrary.Formulas;

class Program
{
    static void Main()
    {
        do
        {
            try
            {
                Console.Write("First number: ");
                BasicWithProperties.firstNumber = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Second number: ");
                BasicWithProperties.secondNumber = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Addition: " + BasicWithProperties.getAddition());
                Console.WriteLine("Subtraction: " + BasicWithProperties.getSubtraction());
                Console.WriteLine("Multiplication: " + BasicWithProperties.getMultiplication());
               
                if (BasicWithProperties.secondNumber != 0)
                {
                    Console.WriteLine("Division: " + BasicWithProperties.getDivision());
                }
                else
                {
                    Console.WriteLine("Division: Underfined (Cannot divide by zero)");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
                continue;
            }
            Console.WriteLine("Do you want to try again yes or no");
            string tryAgain = Console.ReadLine()?.ToLower();

            if (tryAgain == "y")
            {
                Console.WriteLine("Lets try again");
            }
            else if (tryAgain == "n")
            {
                Console.WriteLine("Thank you for using this program");
                break;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
        while (true);
    }

}
