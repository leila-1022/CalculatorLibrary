using CalculatorLibrary.Formulas.Statistics;


BasicFormulas formulas =  new BasicFormulas();

List<int> numbers = new List<int>();
Console.WriteLine("how many numbers");
int count = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < count; i++)
{
    Console.Write($"{i+1}:");
    int number = Convert.ToInt32(Console.ReadLine());
    numbers.Add(number);
    sum += number;
}
formulas.Numbers = numbers;

List<int> sortedNumbers = formulas.Numbers;
sortedNumbers.Sort();
Console.WriteLine("the sorted number.");
foreach (int number in sortedNumbers)
{
    Console.Write(number + " ");
}

Console.WriteLine("permutation");
Console.Write("enter value for R");
formulas.R = Convert.ToInt32(Console.ReadLine());
Console.Write("enter value for N");
formulas.N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(formulas.Permutation);

