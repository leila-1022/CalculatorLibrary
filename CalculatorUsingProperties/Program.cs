using CalculatorLibrary1;
using CalculatorLibrary1.Formulas;

class Program
{
    static void Main()
    {
      
        Console.Write("Enter first number: ");
        if (decimal.TryParse(Console.ReadLine(), out var firstNumber))
        {
            Console.Write("Enter second number: ");
            if (decimal.TryParse(Console.ReadLine(), out var secondNumber))
            {
                BasicWithProperties.FirstNumber = firstNumber;
                BasicWithProperties.SecondNumber = secondNumber;

                Console.WriteLine($"Addition result: {BasicWithProperties.GetAddition()}");
            }
            else
            {
                Console.WriteLine("Error! Please input a valid number for the second number.");
            }
        }
        else
        {
            Console.WriteLine("Error! Please input a valid number for the first number.");
        }
    }
}
