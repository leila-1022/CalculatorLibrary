using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CalculatorLibrary1.Formulas.Shapes
{
    /// <summary>
    /// Add methods and properties to get the rectangle's Area and Perimeter
    /// </summary>
    public static class Rectangle
    {
        public static double Width { get; set; }
        public static double Length { get; set; }
        public static double Area()
        {
            return Width * Length;
        }

        public static double Perimeter()
        {
            return 2 * (Width + Length);
        }
    }
}