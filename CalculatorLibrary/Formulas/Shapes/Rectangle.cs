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
        public static double Area(double length, double width)
        {
            double Area_2 = length * width; ;
            return Math.Round(Area_2, 2);
        }

        public static double Perimeter(double length, double width)
        {
            double Perimeter_2 = 2 * (length + width);
            return Math.Round(Perimeter_2, 2);
        }
    }
}
