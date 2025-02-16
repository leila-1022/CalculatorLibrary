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
    public class Square
    {
        public static double sideLength {get; set;}

        public static string getArea() {
            return $"the area is {sideLength * sideLength}";
        }

        public static string getPerimeter() {
            return $"the perimeter is {4 * sideLength}";
        }
    }
}
