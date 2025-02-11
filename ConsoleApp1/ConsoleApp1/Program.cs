using System;

namespace ValidateInput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num;
            bool Valid;
            string tryagain;

            do
            {
                Console.Clear();
                Console.Write("Enter a number: ");

                do
                {
                    string userInput = Console.ReadLine();
                    try
                    {
                        num = Convert.ToInt32(userInput);
                        Valid = true;
                        Console.Clear();
                        Console.Write($"The number you inputted is {num}");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.Write("Invalid input.\nPlease enter a valid number: ");
                        Valid = false;
                    }
                } while (!Valid);

                do
                {
                    Console.Write("\n\nDo you want to try again?(y/n): ");
                    tryagain = Console.ReadLine()?.ToLower();

                    if (tryagain == "y")
                    {
                        break;
                    }
                    else if (tryagain == "n")
                    {
                        Console.Clear();
                        Console.Write("Salamat sa Lahat\n");
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid choice. Please enter 'y' or 'n'.");
                    }
                } while (tryagain != "y" && tryagain != "n");

            } while (tryagain == "y");
        }
    }
}
