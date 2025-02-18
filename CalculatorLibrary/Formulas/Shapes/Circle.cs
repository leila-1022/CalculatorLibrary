using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    /// <summary>
    /// Represents a Circle with methods to calculate its area and circumference.
    /// </summary>
    public class Circle
    {
        public double Radius { get; set; }


        public Circle(double radius)
        {
            Radius = radius;
        }


        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}