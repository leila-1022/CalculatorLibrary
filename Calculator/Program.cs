using CalculatorLibrary;

///Flow
///
int a = 0, b = 0;

Console.Write("Enter value for the first number: ");
a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter value for the second number: ");
b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"The sum of {a} and {b} is {CalculatorLibrary.Formulas.Basic.Addition(a, b)}");
Console.WriteLine($"The difference of {a} and {b} is {CalculatorLibrary.Formulas.Basic.Subtraction(a, b)}");
Console.WriteLine($"The product of {a} and {b} is {CalculatorLibrary.Formulas.Basic.Multiplication(a, b)}");
Console.WriteLine($"The quotient of {a} and {b} is {CalculatorLibrary.Formulas.Basic.Division(a, b)}");


