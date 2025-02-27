using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter their name
        Console.Write("Please enter your name: ");
        
        // Read the user's input
        string name = Console.ReadLine();
        
        // Greet the user
        Console.WriteLine("Hello, " + name + "! Welcome to the world of C# programming.");
        
        // Wait for the user to press a key before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}