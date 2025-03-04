using CalculatorLibraryV2.Models;
using System.Globalization;

Numbers _number = new Numbers();
Console.Write("How many numbers do you want to enter?: ");
var counter = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    Console.WriteLine($"Enter number { i + 1}: ");
    var inputtedNumber = Convert.ToInt32(Console.ReadLine());
    _number.ListOfNumbers.Add(inputtedNumber);
}
Console.WriteLine("You entered: ");
foreach (var item in _number.ListOfNumbers)
{
    Console.WriteLine(item. ToString() + " " );
}
