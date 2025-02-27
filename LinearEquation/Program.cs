using CalculatorLibrary.Formulas.LinearEquation;
using static System.Formats.Asn1.AsnWriter;

decimal slope, intercept, x1, x2, x3;

Console.Write("Enter Value of Slope: ");
while (!decimal.TryParse(Console.ReadLine(), out slope))
{
    Console.WriteLine("Invalid input. Please enter a valid number for the slope.");
    Console.Write("Enter Value of Slope: ");
}

// Get valid input for intercept
Console.Write("Enter Value of Intercept: ");

while (!decimal.TryParse(Console.ReadLine(), out intercept))
{
    Console.WriteLine("Invalid input. Please enter a valid number for the intercept.");
    Console.Write("Enter Value of Intercept: ");
}


Console.Write("Enter Value of X1: ");
while (!decimal.TryParse(Console.ReadLine(), out x1))
{
    Console.WriteLine("Invalid input. Please enter a valid number for X1.");
    Console.Write("Enter Value of X1: ");
}


Console.Write("Enter Value of X2: ");
while (!decimal.TryParse(Console.ReadLine(), out x2))
{
    Console.WriteLine("Invalid input. Please enter a valid number for X2.");
    Console.Write("Enter Value of X2: ");
}

Console.Write("Enter Value of X3: ");
while (!decimal.TryParse(Console.ReadLine(), out x3))
{
    Console.WriteLine("Invalid input. Please enter a valid number for X3.");
    Console.Write("Enter Value of X3: ");
}

Console.Clear();
Linear_Equation.Slope = slope;
Linear_Equation.Intercept = intercept;
Linear_Equation.X = x1;
Console.WriteLine($"Y = {slope} * {x1} + {intercept} is: {Linear_Equation.CalculateY()}");

Linear_Equation.X = x2;
Console.WriteLine($"Y = {slope} * {x2} + {intercept} is: {Linear_Equation.CalculateY()}");

Linear_Equation.X = x3;
Console.WriteLine($"Y = {slope} * {x3} + {intercept} is: {Linear_Equation.CalculateY()}");