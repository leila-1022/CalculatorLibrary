// See https://aka.ms/new-console-template for more information
using CalculatorLibrary.Models;

Console.Write("How many numbers do you want? ");
Numbers nums = new Numbers(); 
try
{
    int amtNums = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < amtNums; i++) {
        Console.Write($"num {i+1}: ");
        nums.Add(Convert.ToInt32(Console.ReadLine()));
    }
    Console.Write("You have entered ");
    for (int i = 0; i < amtNums; i++) {
        if (i == 0) {
            Console.Write($"{nums.nums[i]}");
        } else {
            Console.Write($", {nums.nums[i]}");
        }
    }
    Console.WriteLine();
    Console.WriteLine("Getting the average!");
    Console.WriteLine($"The average is {nums.average}");
} catch {}