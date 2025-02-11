using System;
using CalculatorLibrary.Formulas;

class Program
{
    static void Main()
    {
        Console.Write("First number: ");
        BasicWithProperties.firstNumber = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Second number: ");
        BasicWithProperties.secondNumber = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Addition: " + BasicWithProperties.getAddition());
    }
}
