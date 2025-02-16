using System;

namespace CalculatorLibrary.Formulas.Shapes
{
    /// <summary>
    /// Add methods and properties to get the circle's circumference and area
    /// </summary>
    public class Circle
    {
        public static double radius {get; set;}

        public static string getArea() {
            return $"the area is {Math.PI * (radius * radius)}";
        }

        public static string getCircumference() {
            return $"the circumference is {2 * Math.PI * radius}";
        }
    }
}