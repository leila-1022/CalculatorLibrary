using CalculatorLibrary;
using CalculatorLibrary.Formulas;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter value for the first number: ");
        int a = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter value for the second number: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"The sum of {a} and {b} is {CalculatorLibrary.Formulas.Basic.Addition(a, b)}");
        Console.WriteLine($"The difference of {a} and {b} is {CalculatorLibrary.Formulas.Basic.Subtraction(a, b)}");

    }
}
