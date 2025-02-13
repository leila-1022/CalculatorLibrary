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
            return $"{sideLength*sideLength}";
        }

        public static string getPerimeter()  {
            return $"{4 * sideLength}";
        }
    }
}
