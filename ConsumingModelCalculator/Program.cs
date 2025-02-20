using CalculatorLibrary.Models;

Numbers _number =  new Numbers();
_number.ListOfNumbers = new List<int>();
Console.WriteLine("How many numbers do you want to enter?: ");
var counter = Convert.ToInt32(Console.ReadLine()); 
for (int i = 0; i < counter; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    var inputtedNumber = Convert.ToInt32(Console.ReadLine());
    _number.ListOfNumbers.Add(inputtedNumber);
}
Console.WriteLine("\nYou entered: ");7
foreach (var item in _number.ListOfNumbers)
{
    Console.Write(item.ToString() + " ");
}

Console.WriteLine($"\n\nThe average of the entered numbers is: {_number.Average()}");