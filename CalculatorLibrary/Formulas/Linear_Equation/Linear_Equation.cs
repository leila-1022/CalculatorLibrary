using System;

namespace CalculatorLibrary.Formulas.LinearEquation
{
    public static class Linear_Equation
    {
        public static decimal Slope { get; set; }
        public static decimal Intercept { get; set; }
        public static decimal X { get; set; }

     
        public static decimal CalculateY()
        {
            return Slope * X + Intercept;
        }
    }
}
