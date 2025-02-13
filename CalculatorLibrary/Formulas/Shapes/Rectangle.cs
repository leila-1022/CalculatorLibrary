using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    /// <summary>
    /// Add methods and properties to get the rectangle's Area and Perimeter
    /// </summary>
    public static class Rectangle
    {
        public static decimal Length { get; set; }
        public static decimal Width { get; set; }
        public static string GetRectangleArea()
        {
            return $"The Area of a rectangle with length of {Length} and width of {Width} is {Length * Width}";
        }
        public static string GetRectanglePerimeter()
        {
            return $"The Perimeter of a rectangle with length of {Length} and width of {Width} is {2 * (Length + Width)}";
        }
    }
}
