using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Statistics
{
    /// <summary>
    /// Complete the properties below and create a new console application to consume it. Create a Main Menu
    /// </summary>
    public class BasicFormulas
    {
        private List<int> _numbers;

        public List<int> Numbers
        {
            get => _numbers;
            set
            {
                _numbers = value;
                _numbers.Sort();
            }
        }

        /*
         Update these properties. DO NOT CREATE FUNCTIONS HERE.
         */

        //Mean
        public double Mean { get; set; }
        //Median
        public double Median { get; set; }
        //Mode
        public List<int> Mode { get; set; }
        private int _n;
        public int N
        {
            get => _n;
            set
            {
                if (value < 0) throw new ArgumentException("N cannot be negative");

                _n = value;
            }
        }

        private int _r;
        public int R
        {
            get => _r;
            set
            {
                if (value < 0 || value > N) throw new ArgumentException("R must be between 0 and N.");
                _r = value;
            }
        }

        //Permutation
        public long Permutation { get; set; }

        private long Factorial(int num)
        {
            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= 1;
            }

            return result;
        }
    }
}
