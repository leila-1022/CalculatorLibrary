using CalculatorLibrary.Formulas.Statistics;
using CalculatorLibrary;

BasicFormulas Bformula = new BasicFormulas();

var counter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose do you want to enter?: ");
Console.WriteLine("1. Mean");
Console.WriteLine("2. Median");
Console.WriteLine("3. Mode");
Console.WriteLine("4. Permutation");
var choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{ case 1:
        Console.Write("Enter The Number: ");
        for (int i = 0; i < counter; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            var inputtedNumber = Convert.ToInt32(Console.ReadLine());
            Bformula.Numbers.Add(inputtedNumber);
            Bformula.Mean += inputtedNumber;
        }
        Bformula.Numbers.Add(inputtedNumber);
        Bformula.Mean += inputtedNumber;
        break;
    case 2:
        Console.Write("Enter The Number: ");
        for (int i = 0; i < counter; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            var inputtedNumber = Convert.ToInt32(Console.ReadLine());
            Bformula.Numbers.Add(inputtedNumber);
        }
        Bformula.Median(inputtedNumber);
        break;
    case 3:
        Console.Write("Enter The Number: ");
        for (int i = 0; i < counter; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            var inputtedNumber = Convert.ToInt32(Console.ReadLine());
            Bformula.Numbers.Add(inputtedNumber);
        }
        Bformula.Mode(inputtedNumber);

        break;
        case 4:
        Console.Write("Enter The Number: ");
        var inputtedNumber = Convert.ToInt32(Console.ReadLine());
        Bformula.Permutaion(inputtedNumber);
        break;
} default:
{
    Console.WriteLine("Invalid Choice");
    break;
}


    
Console.WriteLine("You entered: ");
foreach (var item in Bformula.Number)
{
    Console.Write(item.ToString() + " ");
}