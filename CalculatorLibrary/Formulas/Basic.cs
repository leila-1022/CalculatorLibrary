using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas
{
    public static class Basic
    {
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static decimal Division(decimal a, decimal b)
        {
            if (b == 0)
                throw new Exception("Denominator cannot be zero.");

            return a / b;
        }
    }
}