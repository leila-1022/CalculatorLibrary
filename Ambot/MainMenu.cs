using System;
using System.Linq;
using CalculatorLibrary.Formulas.Statistics;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicFormulas formulas = new BasicFormulas();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Statistics Calculator - Main Menu");
                Console.WriteLine("1. Enter numbers");
                Console.WriteLine("2. View Mean");
                Console.WriteLine("3. View Median");
                Console.WriteLine("4. View Mode");
                Console.WriteLine("5. View Permutation");
                Console.WriteLine("6. Exit");
                Console.Write("Please choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        // Get numbers from the user
                        Console.WriteLine("Enter numbers separated by space:");
                        var input = Console.ReadLine();
                        var numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToList();
                        formulas.Numbers = numbers;
                        break;

                    case "2":
                        Console.WriteLine($"Mean: {formulas.Mean}");
                        break;

                    case "3":
                        Console.WriteLine($"Median: {formulas.Median}");
                        break;

                    case "4":
                        Console.WriteLine($"Mode: {string.Join(", ", formulas.Mode)}");
                        break;

                    case "5":
                        Console.WriteLine($"Permutation (P({formulas.N},{formulas.R})): {formulas.Permutation}");
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }

                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}