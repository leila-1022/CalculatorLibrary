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
        public static decimal Side { get; set; }

        public static string GetSquArea()
        {
            return $"The area of the square is {Side * Side}";
        }
        public static string GetSquPerimeter()
        {
            return $"The perimeter of the square is {4 * Side}";
        }
    }
}