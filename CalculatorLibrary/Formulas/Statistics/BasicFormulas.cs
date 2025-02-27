using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorLibrary.Formulas.Statistics
{
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
                CalculateStatistics(); // Recalculate when numbers change
            }
        }

        // Mean
        public double Mean { get; private set; }
        // Median
        public double Median { get; private set; }
        // Mode
        public List<int> Mode { get; private set; }
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

        // Permutation
        public long Permutation { get; private set; }

        private long Factorial(int num)
        {
            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }

        // Method to calculate Mean, Median, Mode, and Permutation
        private void CalculateStatistics()
        {
            if (_numbers.Count == 0)
                return;

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
            var numberGroups = _numbers.GroupBy(n => n).OrderByDescending(g => g.Count());
            int maxFrequency = numberGroups.First().Count();
            Mode = numberGroups.Where(g => g.Count() == maxFrequency).Select(g => g.Key).ToList();

            // Permutation Calculation
            if (N >= R && N >= 0 && R >= 0)
            {
                Permutation = Factorial(N) / Factorial(N - R);
            }
        }
    }
}
