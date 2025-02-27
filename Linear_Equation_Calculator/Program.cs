using CalculatorLibrary.Formulas.Linear_Equation;
using CalculatorLibrary;
using System.Xml.Linq;

LinearEquation LinearEquationGraph = new LinearEquation();
bool TryAgain = false;

while (!TryAgain)
{
    Console.Clear();
    Console.WriteLine("+----------------------------------------------------+");
    Console.WriteLine("|      Welcome To Linear Equation: y = Mx + C        |");
    Console.WriteLine("+----------------------------------------------------+");
    try
    {
        Console.Write("Please Input Value for X-Coordinate:  ");
        LinearEquationGraph.X_Coordinate = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Please Input Value for Slope:  ");
        LinearEquationGraph.M_Slope = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Please Input Value for Y-Intercept:  ");
        LinearEquationGraph.C_Intercept = int.Parse(Console.ReadLine() ?? "0");
    }
    catch (Exception)
    {
        Console.WriteLine("Error! Invalid Input! INPUT CONVERTED TO 0");
        Console.ReadKey();
        continue;
    }
    Console.Clear();
    Console.WriteLine("+----------------------------------------------------+");
    Console.WriteLine($"                    Y = {LinearEquationGraph.M_Slope}({LinearEquationGraph.X_Coordinate}) + ({LinearEquationGraph.C_Intercept})                    ");
    Console.WriteLine("+----------------------------------------------------+");
    Console.WriteLine($"If X is {LinearEquationGraph.X_Coordinate}, then Y is {LinearEquationGraph.Y_Coordinate}");
    ConsoleKeyInfo _tryagain = new ConsoleKeyInfo();
    Console.WriteLine("Do you want to try again? Press N for No");
    _tryagain = Console.ReadKey();
    if (_tryagain.KeyChar == 'N' || _tryagain.KeyChar == 'n')
    {
        break;
    }
}