using CalculatorLibrary;

class Program
{
    static void Main(string[] args)
    {

        int firstNumber = 0, secondNumber = 0;

        Console.Write("Enter value for the first number: ");
        if (int.TryParse(Console.ReadLine() ?? "0", out firstNumber))
        {
            Console.Write("Enter value for the second number: ");
            if (int.TryParse(Console.ReadLine() ?? "0", out secondNumber))
            {
                Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {CalculatorLibrary.Formulas.Basic.Addition(firstNumber, secondNumber)}");
                Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is {CalculatorLibrary.Formulas.Basic.Subtraction(firstNumber, secondNumber)}");
                Console.WriteLine($"The product of {firstNumber} and {secondNumber} is {CalculatorLibrary.Formulas.Basic.Multiplication(firstNumber, secondNumber)}");
                Console.WriteLine($"The quotient of {firstNumber} and {secondNumber} is {CalculatorLibrary.Formulas.Basic.Division(firstNumber, secondNumber)}");
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