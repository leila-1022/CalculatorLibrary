using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    public static class Rectangle
    {
        public static decimal Length { get; set; }
        public static decimal Width { get; set; }

        public static string GetRecArea()
        {
            return $"The area of the rectangle is {Length * Width}";
        }
        public static string GetRecPerimeter()
        {
            return $"The perimeter of the rectangle is {2 * (Length + Width)}";
        }
    }
}
