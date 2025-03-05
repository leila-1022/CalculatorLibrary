using CalculatorLibrary.Formulas;

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
                BasicWithProperties.firstNumber = firstNumber;
                BasicWithProperties.secondNumber = secondNumber;

                Console.WriteLine($"Addition result: {BasicWithProperties.getAddition()}");
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
