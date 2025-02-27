using CalculatorLibrary.Formulas.Models;
using CalculatorLibrary;

Numbers _number = new Numbers();
_number.ListOfNumbers = new List<int>();
Console.WriteLine("How many numbers do you want to enter?: ");
var counter = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < counter; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    var inputtedNumber = Convert.ToInt32(Console.ReadLine());
    _number.ListOfNumbers.Add(inputtedNumber);
    _number.Average += inputtedNumber;
}
Console.WriteLine("You entered: ");
foreach (var item in _number.ListOfNumbers)
{
    Console.Write(item.ToString() + " ");
}

_number.ListOfNumbers.Sort();
Console.WriteLine("\nSorted: ");
foreach (var item in _number.ListOfNumbers)
{
    Console.Write(item.ToString() + " ");
}

if (counter % 2 == 0)
{
    _number.Median = (_number.ListOfNumbers[(counter / 2) - 1] + _number.ListOfNumbers[counter / 2]) / 2.0;
}
else
{
    _number.Median = _number.ListOfNumbers[counter / 2];
}

Console.WriteLine($"\nThe average of the numbers is: {_number.Average / counter}");
Console.WriteLine($"\nThe mean of the numbers is: {_number.Average / counter}");
Console.WriteLine($"\nTHe median of the numbers is: {_number.Median}");