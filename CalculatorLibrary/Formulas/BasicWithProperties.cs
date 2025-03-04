using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas
{
    public static class BasicWithProperties
    {
        public static decimal firstNumber { get; set; }
        public static decimal secondNumber { get; set; }

        public static string getAddition()
        {
            return $"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}.";
        }
        public static string getSubtraction()
        {
            return $"The difference between {firstNumber} and {secondNumber} is {firstNumber - secondNumber}.";
        }
        public static string getMultiplication()
        {
            return $"The product of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}.";
        }
        public static string getDivision()
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                return "Division by zero is not allowed.";
            }
            return $"The quotient of {firstNumber} and {secondNumber} is {firstNumber / secondNumber}'";
        }
    }
}
