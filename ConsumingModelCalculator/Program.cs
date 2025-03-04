using CalculatorLibrary1.Models;

double Average;

Numbers _number = new Numbers();
_number.ListOfNumbers = new List<int>();
Console.WriteLine("How many numbers do you want to enter?: ");

var counter = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < counter; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    var inputtedNumber = Convert.ToInt32(Console.ReadLine());
    _number.ListOfNumbers.Add(inputtedNumber);
}
Average = _number.ListOfNumbers.Sum() / (double)_number.ListOfNumbers.Count;

Console.WriteLine("You entered: ");
foreach (var item in _number.ListOfNumbers)
{
    Console.WriteLine(item.ToString() + " ");
}
{
    Console.WriteLine("The Total Average is " + Average);
}

int sum1, sum2, total;

Console.WriteLine("Input a number: ");
sum1 = _number.ListOfNumbers.Sum();
Console.WriteLine("Input a number: ");
sum2 = _number.ListOfNumbers.Sum();

total = _number.ListOfNumbers.Count();
Console.WriteLine();

if (sum1 > sum2)
{
    Console.WriteLine();
}
else if (sum2 > total)
{
    Console.WriteLine();
}


