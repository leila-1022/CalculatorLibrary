using CalculatorLibrary.Models;
using System.Globalization;

Numbers _number = new Numbers();
_number.ListOfNumbers = new List<int>();

Console.WriteLine("How many numbers do you want to enter: ");
var counter = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    Console.WriteLine($"Enter number {i + 1}: ");
    var InputtedNumber = Convert.ToInt32(Console.ReadLine());
    _number.ListOfNumbers.Add(InputtedNumber);
}

Console.WriteLine("You entered: ");
foreach (var item in _number.ListOfNumbers)
{
    Console.Write(item.ToString() + " ");
}

Console.WriteLine();

double average = _number.ListOfNumbers.Average();
Console.WriteLine($"The average of all the number is: {average}");