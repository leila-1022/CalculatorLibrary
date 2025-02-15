using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    public static class Circle
    {
        public static double Circumference(double radius)
        {
            double radius_S = 2 * Math.PI * radius; ;
            return (Math.Round(radius_S, 2));
        }

        public static double Area(double radius)
        {
            double radius_A = Math.PI * Math.Pow(radius, 2);
            return (Math.Round(radius_A, 2));
        }
    }
}