﻿
class Program
{
    static void Main(string[] args)
    {

        int firstNumber = 0, secondNumber = 0;

Console.Write("Enter value for the second number: ");
b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"The sum of {a} and {b} is {CalculatorLibrary.Formulas.Basic.Addition(a, b)}");
Console.WriteLine($"The difference of {a} and {b} is {CalculatorLibrary.Formulas.Basic.Subtraction(a, b)}");

