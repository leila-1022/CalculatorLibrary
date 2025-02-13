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
    public class Rectangle
    {
        public static double height {get; set;}
        public static double width {get; set;} 

        public static string getArea() {
            return $"{height * width}";
        }

        public static string getPerimeter() {
            return $"{2 * (width + width)}";
        }
    }
}
