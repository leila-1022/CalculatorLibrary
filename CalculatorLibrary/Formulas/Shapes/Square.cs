using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    /// <summary>
    /// Add methods and properties to get the square's Area and Perimeter
    /// </summary>
    public static class Square
    {
        public static double Area(double side)
        {
            double Square_A = Math.Pow(side, 2); ;
            return Math.Round(Square_A, 2);
        }
        public static double Perimeter(double side)
        {
            double Square_P = 4 * side; ;
            return Math.Round(Square_P, 2);
        }
    }
}
