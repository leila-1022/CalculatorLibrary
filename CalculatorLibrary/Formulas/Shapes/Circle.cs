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
    public static class Circle
    {
        public static double Radius { get; set; }

        public static double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public static double Circumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}

