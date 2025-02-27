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
                    ShowMean(stats);
                    break;
                case "3":
                    ShowMedian(stats);
                    break;
                case "4":
                    ShowMode(stats);
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

        if (numbers.Count > 0)
        {
            stats.Numbers = numbers;
            Console.WriteLine("Numbers updated successfully!");
        }
        else
        {
            Console.WriteLine("No valid numbers entered. Please try again.");
        }
    }

    static void ShowMean(BasicFormulas stats)
    {
        if (stats.Numbers.Count > 0)
        {
            Console.WriteLine($"Mean: {stats.Mean}");
        }
        else
        {
            Console.WriteLine("No numbers entered. Please enter numbers first.");
        }
    }

    static void ShowMedian(BasicFormulas stats)
    {
        if (stats.Numbers.Count > 0)
        {
            Console.WriteLine($"Median: {stats.Median}");
        }
        else
        {
            Console.WriteLine("No numbers entered. Please enter numbers first.");
        }
    }

    static void ShowMode(BasicFormulas stats)
    {
        if (stats.Numbers.Count > 0)
        {
            Console.WriteLine("Mode: " + string.Join(", ", stats.Mode));
        }
        else
        {
            Console.WriteLine("No numbers entered. Please enter numbers first.");
        }
    }

    static void CalculatePermutation(BasicFormulas stats)
    {
        Console.Write("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter value for R: ");
        int r = int.Parse(Console.ReadLine());

        stats.N = n;
        stats.R = r;

        Console.WriteLine($"Permutation (P({n},{r})): {stats.Permutation}");
    }
}
