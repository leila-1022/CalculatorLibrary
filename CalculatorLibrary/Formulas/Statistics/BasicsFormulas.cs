using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        public double Mean
        {
            get
            {
                int sum = 0;
                foreach (int i in _numbers)
                {
                    sum += i;
                }
                return sum / _numbers.Count;
            }
        }
        //Median
        public double Median
        {
            get
            {
                if (_numbers.Count % 2 == 0)
                {
                    return (double)(_numbers[(_numbers.Count / 2) - 1] + _numbers[_numbers.Count / 2]) / 2;
                }
                else
                {
                    return _numbers[_numbers.Count / 2];
                }
            }
        }
        //Mode
        public List<int> Mode
        {
            get
            {

                Dictionary<int, int> frequency = new Dictionary<int, int>();


                foreach (int num in _numbers)
                {
                    if (frequency.ContainsKey(num))
                        frequency[num]++;
                    else
                        frequency[num] = 1;
                }

                int maxFrequency = frequency.Values.Max();

                return frequency.Where(x => x.Value == maxFrequency)
                            .Select(x => x.Key)
                            .ToList();

            }
        }
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
                if (value < 0 || value > _n) throw new ArgumentException("R must be between 0 and N.");
                _r = value;
            }
        }

        //Permutation
        public long Permutation
        {
            get
            {
                return Factorial(_n) / Factorial(_n - _r);
            }
        }
        private long Factorial(int num)
        {
            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i; // Fix: Multiply by `i` instead of `1`
            }
            return result;
        }
    }
}
