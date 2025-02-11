using CalculatorLibrary;
using CalculatorLibrary.Formulas;

Console.Write("Enter first number: ");
decimal.TryParse(Console.ReadLine(), out var FirstNumber);
Console.Write("Enter second number: ");
decimal.TryParse(Console.ReadLine(), out var SecondNumber);

BasicwithProperties.FirstNumber = FirstNumber;
BasicwithProperties.SecondNumber = SecondNumber;
Console.WriteLine(BasicwithProperties.GetAddition());