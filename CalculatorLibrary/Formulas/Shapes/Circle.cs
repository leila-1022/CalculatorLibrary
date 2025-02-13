using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    /// <summary>
    /// Add methods and properties to get the circle's circumference and area
    /// </summary>
    public class Circle
    {
        public static double radius {get; set;}

        public static string getArea() {
            return $"{Math.PI * (radius * radius)}";
        }

        public static string getPerimeter() {
            return $"{2 * Math.PI * radius}";
        }
    }
}
