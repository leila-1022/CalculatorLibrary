﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public static class Basic
    {
        public static decimal FirstNumber { get; set; }
        public static decimal SecondNumber { get; set; }
        
        public static string getAddition()
        {
            return $"The sum of {FirstNumber} and {SecondNumber} is {FirstNumber + SecondNumber}";
        }

    }

}
