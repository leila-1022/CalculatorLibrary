using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    /// <summary>
    /// Add methods and properties to get the square's Area and Perimeter
    /// </summary>
    public static class Square
    {
        public static double Side { get; set; }

        public static double Area()
        {
            return Side * Side;
        }
        public static double Perimeter()
        {
            return 4 * Side;
        }
    }

}