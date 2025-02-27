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
                    _numbers = new List<int>(value);
            }
        }
        public void SetSingleNumber(int number)
        {
            Numbers = new List<int> { number };
        }


        /*
         Update these properties. DO NOT CREATE FUNCTIONS HERE.
         */

        private int _count;
        public int Count
        {
            get
            { return _count; }
            set { if (value < 0) throw new ArgumentException("Error Occured, Invalid Input"); 
            _count = value;
            } 
        }   
        //Mean
        private double _median;
        private int _mode;
        private int _maxcount;
        public double Mean { get; set; }
        //Median
        public double Median 
        {
            get
            {
                if (_count % 2 == 0)
                {
                    return _median = (Numbers[(_count / 2) - 1] + Numbers[_count /  2]) / 2.0;
                } else
                {
                    return _median = Numbers[_count / 2];
                }
            }
            set { _median = value; }
        }
        //Mode
        public int Mode
        {
            get
            {
                Dictionary<int, int> frequent = new Dictionary<int, int>();
                foreach (var num in Numbers)
                {
                    if (!frequent.ContainsKey(num))
                    {
                        frequent[num] = 0;
                    }
                    else { frequent[num] += 1; }

                    if (frequent[num] > _maxcount)
                    {
                        _maxcount = frequent[num];
                        _mode = num;
                    }
                }
                return _mode;
            }
            set { _mode = value; }
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
                try
                {
                    _r = value;
                }catch (Exception)
                {
                    Console.WriteLine("Error! Invalid Input, Reminder! -- R must be between 0, Characters and Keys are not ALLOWED, and R cannot be below 0");
                }
            }
        }

        //Permutation
        public long Permutation => Factorial(N) / Factorial(N - R);

        private long Factorial(int num)
        {
            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}