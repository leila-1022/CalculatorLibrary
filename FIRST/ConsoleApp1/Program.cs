using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string numeroInput = Console.ReadLine();
                Console.WriteLine("Enter your name: ");
                string pangalan = Console.ReadLine();

                Console.WriteLine($"You age is: {numeroInput}");
                Console.Write($"Your name is: {pangalan}");
                Console.WriteLine();

                Console.WriteLine("Do you want to try exit? (y/n): ");
                string exitInput = Console.ReadLine();
                if (exitInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}