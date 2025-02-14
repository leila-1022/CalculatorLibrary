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

        public static double CalculateArea(double side)
        {
            return side * side; // Area = side * side
        }

        public static double CalculatePerimeter(double side)
        {
            return 4 * side; // Perimeter = 4 * side
        }
    }
}