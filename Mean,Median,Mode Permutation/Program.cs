using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Statistics & Permutations Calculator ====");
            Console.WriteLine("1. Mean");
            Console.WriteLine("2. Median");
            Console.WriteLine("3. Mode");
            Console.WriteLine("4. Permutation");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "5") return;

            if (choice == "4")
            {
                Console.Write("Enter N: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter R: ");
                int r = int.Parse(Console.ReadLine());

                Console.WriteLine($"Permutation (NPr): {Permutation(n, r)}");
            }
            else
            {
                Console.Write("Enter numbers (space-separated): ");
                List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

                switch (choice)
                {
                    case "1": Console.WriteLine($"Mean: {numbers.Average()}"); break;
                    case "2": Console.WriteLine($"Median: {Median(numbers)}"); break;
                    case "3": Console.WriteLine($"Mode: {string.Join(", ", Mode(numbers))}"); break;
                    default: Console.WriteLine("Invalid choice."); break;
                }
            }
            Console.ReadLine();
        }
    }

    static long Factorial(int num) => num <= 1 ? 1 : num * Factorial(num - 1);

    static long Permutation(int n, int r) => Factorial(n) / Factorial(n - r);

    static double Median(List<int> numbers)
    {
        numbers.Sort();
        int mid = numbers.Count / 2;
        return numbers.Count % 2 == 0 ? (numbers[mid - 1] + numbers[mid]) / 2.0 : numbers[mid];
    }

    static List<int> Mode(List<int> numbers)
    {
        var freq = numbers.GroupBy(n => n).OrderByDescending(g => g.Count());
        int maxCount = freq.First().Count();
        return freq.Where(g => g.Count() == maxCount).Select(g => g.Key).ToList();
    }
}
