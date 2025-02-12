using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas
{
    public class BasicWithProperties
    {
        public static decimal FirstNumber { get; set; }
        public static decimal SecondNumber { get; set; }

        public static string getAddition()
        {
            return $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}";
        }

    }
}