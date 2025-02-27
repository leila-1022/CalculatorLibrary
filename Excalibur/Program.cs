using CalculatorLibrary.Formulas.Statistics;
using System;
using System.Collections.Generic;

bool TryAgain = false;

while (!TryAgain)
{
    Console.Clear();
    BasicFormulas statistics = new BasicFormulas();
    Console.WriteLine("+---------------------------------------------------+");
    Console.WriteLine("|          Welcome to the Calculator App            |");
    Console.WriteLine("|   Please select an option from the menu below:    |");
    Console.WriteLine("| 1. Mean, Median, and Mode                         |");
    Console.WriteLine("| 2. Permutation                                    |");
    Console.WriteLine("+---------------------------------------------------+");

    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();

    if (key.KeyChar == '1')
    {
        Console.Write("Please Input How Many Numbers You Want To Enter: ");
        statistics.Count = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Please Enter The Numbers:");
        List<int> numbers = new List<int>();

        for (int Iteration = 0; Iteration < statistics.Count; Iteration++)
        {
            try
            {
                Console.Write($"Number {Iteration + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine() ?? "0"));
                statistics.Mean += numbers[Iteration];
            }
            catch (Exception)
            {
                Console.WriteLine("Error, Try Again");
                Iteration -= 1;
            }
        }
        statistics.Mean = statistics.Mean / statistics.Count;
        statistics.Numbers = numbers;
        Console.Clear();
        Console.WriteLine($"Your Numbers: {string.Join(" ", statistics.Numbers)}");
        statistics.Numbers.Sort();
        Console.WriteLine($"Your Mean is {statistics.Mean}");
        Console.WriteLine($"Your Median is {statistics.Median}");
        Console.WriteLine($"Your Mode is {statistics.Mode}");
    }
    else if (key.KeyChar == '2')
    {
        Console.Write("Please Input The Value of n: ");
        statistics.N = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Please Input The Value of r: ");
        statistics.R = int.Parse(Console.ReadLine() ?? "0");
<<<<<<< HEAD
        if (statistics.N <= 0 && statistics.R <= 0)
        {
            Console.WriteLine("Invalid Input, Press Key To Try Again From the Top");
=======
        if (statistics.N <= 0 && statistics.R <= 0) 
        {Console.WriteLine("Invalid Input, Press Key To Try Again From the Top");
>>>>>>> 909f87470720e29025fb30048e59bf4b50af74fb
            Console.ReadKey();
            continue;
        }
        Console.WriteLine($"The Permutation of {statistics.N} and {statistics.R} is {statistics.Permutation}");
    }
    else
    {
        Console.WriteLine("Invalid Input");
    }

    Console.WriteLine("Would You Like To Try Again? (Y/N)");
    TryAgain = Console.ReadKey().KeyChar is not ('Y' or 'y');
}
