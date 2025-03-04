using System;
using CalculatorLibrary.Models;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Numbers _number = new Numbers();

        _number.ListOfNumbers = new List<int>();

        Console.WriteLine("How many numbers do you want to enter?: ");
        var counter = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < counter; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            var inputtedNumber = Convert.ToInt32(Console.ReadLine());
            _number.ListOfNumbers.Add(inputtedNumber);
        }

        Console.WriteLine("You entered: ");
        foreach (var item in _number.ListOfNumbers)
        {
            Console.Write(item.ToString() + " ");
        }
        if (_number.ListOfNumbers.Count > 0)
        {
            double average = _number.ListOfNumbers.Average();
            Console.WriteLine($"\nThe average of the numbers {average}");
        }
        else
        {
            Console.WriteLine("\n No Numbers Entered");
        }


    }
}