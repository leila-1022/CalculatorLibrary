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
    /// 


    public static class Circle
    {

        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;  // Area = ?r²
        }

        // Method to calculate the circumference of the circle
        public static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius; // Circumference = 2?r
        }

        // Method to calculate the diameter of the circle
        public static double CalculateDiameter(double radius)
        {
            return 2 * radius; // Diameter = 2r
        }

    }
}