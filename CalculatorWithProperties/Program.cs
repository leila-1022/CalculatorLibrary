using CalculatorLibrary;
using CalculatorLibrary.Formulas;

Console.Write("Enter First Number: ");
decimal.TryParse(Console.ReadLine(), out var firstNumber);
Console.Write("Enter Second Number: ");
decimal.TryParse(Console.ReadLine(), out var secondNumber);

BasicwithProperties.FirstNumber = firstNumber;
BasicwithProperties.SecondNumber = secondNumber;
Console.WriteLine(BasicwithProperties.GetAddition());
g