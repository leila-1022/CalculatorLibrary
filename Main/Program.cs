using CalculatorLibrary.Formulas;
using System;
using System.Globalization;
using CalculatorLibrary.Formulas.Statistics;

BasicFormulas nums = new BasicFormulas();

void getStatisticsData() {
    int amtNums;
    try
    {
        amtNums = Convert.ToInt32(Console.ReadLine());

        List<int> data = new List<int>();
        for (int i = 0; i < amtNums; i++)
        {
            Console.Write($"num {i + 1}: ");
            data.Add(Convert.ToInt32(Console.ReadLine()));
        }
        nums.Numbers = data;
    }
    catch { }
}

while (true)
{
    Console.Clear();
    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Mean");
    Console.WriteLine("2. Median");
    Console.WriteLine("3. Mode");
    Console.WriteLine("4. Permutation");

    Console.Write("Choose between the options: ");
    string choice = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("How many numbers? ");
    
    switch (choice)
    {
        case "1":
            getStatisticsData();
            Console.WriteLine("Mean Calculator");
            Console.WriteLine($"The mean is {nums.Mean}");
            break;
        case "2":
            getStatisticsData();
            Console.WriteLine("Median Calculator");
            Console.WriteLine($"The median is {nums.Median}");
            break;
        case "3":
            getStatisticsData();
            Console.WriteLine("Mode Calculator");
            foreach (int mode in nums.Mode) {
                Console.WriteLine($"mode {mode}");
            }
            break;
        case "4":
            int nInput, rInput;
            try
            {
                Console.Write("N: ");
                nInput = Convert.ToInt32(Console.ReadLine());
                Console.Write("R: ");
                rInput = Convert.ToInt32(Console.ReadLine());

                nums.N = nInput;
                nums.R = rInput;
            }
            catch { }
            Console.WriteLine("Permutation Calculator");
            Console.WriteLine($"The permutation is {nums.Permutation}");
            break;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }

    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();

}