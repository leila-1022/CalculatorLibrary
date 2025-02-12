using CalculatorLibraryE;
using CalculatorLibraryE.Formulas;

int a = 0, b = 0;

Console.Write("Enter value for the first number: ");
a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter value for the second number: ");
b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"The sum of {a} and {b} is {Basic.Addition(a, b)}");
Console.WriteLine($"The difference of {a} and {b} is {Basic.Subtraction(a, b)}");