using System;
using System.Collections.Generic;
using CalculatorLibrary.Formulas.Statistics;

class Program
{
    static void Main()
    {
        BasicFormulas stats = new BasicFormulas();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Statistics Calculator =====");
            Console.WriteLine("1. Enter Numbers");
            Console.WriteLine("2. Show Mean");
            Console.WriteLine("3. Show Median");
            Console.WriteLine("4. Show Mode");
            Console.WriteLine("5. Calculate Permutation (N P R)");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    EnterNumbers(stats);
                    break;
                case "2":
                    Console.WriteLine($"Mean: {stats.Mean}");
                    break;
                case "3":
                    Console.WriteLine($"Median: {stats.Median}");
                    break;
                case "4":
                    Console.WriteLine("Mode: " + string.Join(", ", stats.Mode));
                    break;
                case "5":
                    CalculatePermutation(stats);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void EnterNumbers(BasicFormulas stats)
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        List<int> numbers = new List<int>();

        foreach (var num in input.Split(' '))
        {
            if (int.TryParse(num, out int value))
                numbers.Add(value);
            else
                Console.WriteLine($"'{num}' is not a valid number.");
        }

        stats.Numbers = numbers;
        Console.WriteLine("Numbers updated successfully!");
    }

    static void CalculatePermutation(BasicFormulas stats)
    {
        Console.Write("Enter value for N: ");
        stats.N = int.Parse(Console.ReadLine());

        Console.Write("Enter value for R: ");
        stats.R = int.Parse(Console.ReadLine());

        Console.WriteLine($"Permutation (P({stats.N},{stats.R})): {stats.Permutation}");
    }
}