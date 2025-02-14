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

        public static double CalculateArea(double width, double height)
        {
            return width * height;
        }


        public static double CalculatePerimeter(double width, double height)
        {
            return 2 * (width + height);
        }
    }
}