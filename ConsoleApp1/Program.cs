using CalculatorLibrary;
using CalculatorLibrary.Formulas;

Console.Write("Enter first number: ");
decimal.TryParse(Console - ReadLine(), out var firstNumber);
Console.Write"Enter second number: “);
decimal.TryParse(Console: ReadLine(), out var secondNumber);

BasicWithProperties.FirstNumber = firstNumber;
BasicWithProperties.SecondNumber = secondNumber;
Console.WriteLine(BasicWithProperties.GetAddition());