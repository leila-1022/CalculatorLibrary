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

        public static decimal Sides { get; set; }
        public static string GetSquareArea()
        {
            if (Sides <= 0)
            {
                return "Sides must be a positive number.";
            }
            return $"The Area of a square with {Sides} is {Sides * Sides}";
        }
        public static string GetSquarePerimeter()
        {
            if (Sides <= 0)
            {
                return "Sides must be a positive number.";
            }
            return $"The Perimeter of a square with {Sides} is {4m * Sides}";
        }
    }
}

