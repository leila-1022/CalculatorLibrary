using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    /// <summary>
    /// Add methods and properties to get the circle's circumference and area
    /// </summary>
    public static class Circle
    {

        public static decimal Diameter { get; set; }
        public static decimal Radius { get; set; }
        public static decimal Pi { get; set; } = 3.14m;
        public static decimal Area { get; set; }

        public static string GetCircumferenceUsingDiameter()
        {
            if (Diameter <= 0)
            {
                return "Diameter must be a positive number.";
            }
            return $"The circumference of a circle with {Diameter} is {Pi * Diameter}";

        }
        public static string GetCircumferenceUsingRadius()
        {
            if (Radius <= 0)
            {
                return "Radius must be a positive number.";
            }
            return $"The circumference of a circle with {Radius} is {2 * Pi * Radius}";
        }

        public static string GetAreaUsingDiameter()
        {
            if (Diameter <= 0)
            {
                return "Diameter must be a positive number.";
            }
            return $"The Area of a circle with {Diameter} is {0.25m * Pi * Diameter * Diameter}";
        }
        public static string GetAreaUsingRadius()
        {
            if (Radius <= 0)
            {
                return "Radius must be a positive number.";
            }
            return $"The Area of a circle with {Radius} is {Pi * Radius * Radius}";
        }
    }
}


