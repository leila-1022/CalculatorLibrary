using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Formulas
{
    public static class Class1
    {
        public static decimal FirstNumber { get; set; }
        public static decimal SecondNumber { get; set; }

        public static string getAddition()
        {
            return $"the sum of the {FirstNumber} and {SecondNumber} is {FirstNumber + SecondNumber}";
        }
    }
}
