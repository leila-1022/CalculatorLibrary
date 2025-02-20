using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorLibrary.Formulas.Statistics
{
    /// <summary>
    /// This class provides basic statistical calculations, including Mean, Median, Mode, and Permutations.
    /// </summary>
    public class BasicFormulas
    {
        private List<int> _numbers = new List<int>();

        public List<int> Numbers
        {
            get => _numbers;
            set
            {
                _numbers = value ?? new List<int>(); // Ensure it's not null
                _numbers.Sort();
                UpdateStatistics();
            }
        }

        // Mean
        public double Mean { get; private set; }

        // Median
        public double Median { get; private set; }

        // Mode
        public List<int> Mode { get; private set; } = new List<int>();

        private int _n;
        public int N
        {
            get => _n;
            set
            {
                if (value < 0) throw new ArgumentException("N cannot be negative");
                _n = value;

                // Ensure R is valid when N changes
                if (_r > _n)
                    _r = _n;

                UpdatePermutation();
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
                    if (value < 0 || value > N)
                    {
                        throw new ArgumentException("R must be between 0 and N.");
                    }
                    _r = value;
                    UpdatePermutation();
                }
                catch (Exception)
                {
                    Console.WriteLine("STUUUBIIDDDD R should be smaller than N");
                }
            }
        }

        // Permutation
        public long Permutation { get; private set; }

        private void UpdateStatistics()
        {
            if (_numbers == null || _numbers.Count == 0)
            {
                Mean = 0;
                Median = 0;
                Mode = new List<int>();
                return;
            }

            // Mean Calculation
            Mean = _numbers.Average();

            // Median Calculation
            int count = _numbers.Count;
            if (count % 2 == 0)
            {
                Median = (_numbers[count / 2 - 1] + _numbers[count / 2]) / 2.0;
            }
            else
            {
                Median = _numbers[count / 2];
            }

            // Mode Calculation
            var frequency = _numbers.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
            int maxFreq = frequency.Values.Max();
            Mode = frequency.Where(x => x.Value == maxFreq).Select(x => x.Key).ToList();
        }

        private void UpdatePermutation()
        {
            if (N >= 0 && R >= 0 && N >= R)
            {
                Permutation = Factorial(N) / Factorial(N - R);
            }
            else
            {
                Permutation = 0;
            }
        }

        private long Factorial(int num)
        {
            if (num == 0) return 1; // Fix for zero factorial case
            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
