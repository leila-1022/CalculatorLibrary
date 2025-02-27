using CalculatorLibrary;
using CalculatorLibrary.Formulas;

LQFormulas lqFormulas = new LQFormulas();
while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome to Linear Equation Calculator\n");
    decimal slope, intercept;
    while (true) {
        Console.Write("Enter value for slope: ");
        if (!decimal.TryParse(Console.ReadLine(), out slope))
        {
            Console.WriteLine("Pls input a decimal");
        }
        else {
            break;
        }
    }
    while (true) {
        Console.Write("Enter value for intercept: ");
        if (!decimal.TryParse(Console.ReadLine(), out intercept))
        {
            Console.WriteLine("Pls input a decimal");
        }
        else {
            break;
        }
    }
    List<double> xs = new List<double>();
    int xLength;
    while (true)
    {
        Console.Write("How many x: ");
        if (!Int32.TryParse(Console.ReadLine(), out xLength))
        {
            Console.WriteLine("Pls. enter a number");
        }
        else {
            break;
        }
    }
    for (int i = 0; i < xLength; i++) {
        while (true) {
            Console.Write("Enter value for x: ");
            if (!decimal.TryParse(Console.ReadLine(), out var x))
            {
                Console.WriteLine("Pls input a decimal\n");
            }
            else {
                xs.Add((double)x);
                break;
            }
        }
    }

    lqFormulas.slope = (double)slope;
    lqFormulas.intercept = (double)intercept;
    foreach (double x in xs) {
        lqFormulas.x = x;
        Console.WriteLine("\n");
        Console.WriteLine($"(x = {x})");
        Console.WriteLine($"y = {lqFormulas.slope}*{x}+{lqFormulas.intercept}");
        Console.WriteLine($"y = {lqFormulas.linear}");
    }

    bool doYouWantToContinue = false;
    while (!doYouWantToContinue) {
        Console.Write("\nDo you want to try again?(y/n): ");
        ConsoleKey key = Console.ReadKey().Key;
        if (key == ConsoleKey.Y) {
            doYouWantToContinue = true;
            break;
        } else if (key == ConsoleKey.N) {
            doYouWantToContinue = false;
            break;
        }
    }
    if (!doYouWantToContinue) {
        break;
    }
}