using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Shapes
{
    public class Circle
    {
        public static decimal Diameter { get; set; }
        public static decimal Radius { get; set; }
        public static decimal Area { get; set; }
        public static decimal Circumference { get; set; }

        public static decimal PI { get; set; } = 3.14159m;

        public static string GetCircRadius()
        {
            return $"The circumference of the circle is {2 * PI * Radius}";
        }
        public static string GetCircDiameter()
        {
            return $"The circumference of the circle is {PI * Diameter}";
        }
        public static string GetCircArea()
        {
            return $"The circumference of the circle is {2 * (decimal)Math.Sqrt((double)(PI * Area))}";
        }
        public static string GetAreaRadius()
        {
            return $"The area of the circle is {PI * Radius * Radius}";
        }
        public static string GetAreaDiameter()
        {
            return $"The area of the circle is {(PI * Diameter * Diameter) / 4}";
        }
        public static string GetAreaCircumference()
        {
            return $"The area of the circle is {(Circumference * Circumference) / (4 * PI)}";
        }
    }
}
