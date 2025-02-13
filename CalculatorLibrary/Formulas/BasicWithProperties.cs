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

        public static string getAddition()
        {
            return $"The sum of {FirstNumber} and {SecondNumber} is {FirstNumber + SecondNumber}";
        }

        public static string getSubtraction()
        {
            return $"The difference of {FirstNumber} and {SecondNumber} is {FirstNumber - SecondNumber}";
        }

        public static string getMultiplication()
        {
            return $"The product of {FirstNumber} and {SecondNumber} is {FirstNumber * SecondNumber}";
        }

        public static string getDivision()
        {
            if (SecondNumber == 0)
                throw new Exception("Denominator cannot be zero.");

            return $"The quotient of {FirstNumber} and {SecondNumber} is {FirstNumber / SecondNumber}";
        }
    }
}
