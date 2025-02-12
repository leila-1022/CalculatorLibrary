using ClassLibrary;
using ClassLibrary.Formulas;

Console.WriteLine("Enter first number:");
decimal.TryParse(Console.ReadLine(), out var firstNumber);
Console.WriteLine("Enter second number:");
decimal.TryParse(Console.ReadLine(), out var secondNumber);

Class1.FirstNumber = firstNumber;
Class1.SecondNumber = secondNumber;

Console.WriteLine(Class1.getAddition());


