using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas
{
    public static class BasicWithProperties
    {
        public static decimal FirstNumber { get; set; }
        public static decimal SecondNumber { get; set; }

        public static string GetAddition()
        {
            return $"The sum of {FirstNumber} and {SecondNumber} is {FirstNumber + SecondNumber}";
        }
        public static string GetSubtraction()
        {
            return $"The difference of {FirstNumber} and {SecondNumber} is {FirstNumber - SecondNumber}";
        }
        public static string GetMultiplication()
        {
            return $"The product of {FirstNumber} and {SecondNumber} is {FirstNumber * SecondNumber}";
        }
        public static string GetDivision()
        {
            if (SecondNumber == 0)
                throw new Exception("Denominator cannot be zero.");

            return $"The quotient of {FirstNumber} and {SecondNumber} is {FirstNumber / SecondNumber}";
        }
    }
}