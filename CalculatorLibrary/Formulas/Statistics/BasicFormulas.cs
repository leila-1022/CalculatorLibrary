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
                _numbers = value ?? new List<int>();
                _numbers.Sort();  // Sorting the numbers to facilitate calculations like Median
            }
        }

        // Mean calculation: If no numbers, returns 0
        public double Mean => _numbers.Count == 0 ? 0 : _numbers.Average();

        // Median calculation: Handles both odd and even number of elements
        public double Median
        {
            get
            {
                if (_numbers.Count == 0) return 0;

                int mid = _numbers.Count / 2;
                return _numbers.Count % 2 == 0
                    ? (_numbers[mid - 1] + _numbers[mid]) / 2.0
                    : _numbers[mid];
            }
        }

        // Mode calculation: Returns the most frequent numbers
        public List<int> Mode
        {
            get
            {
                if (_numbers.Count == 0) return new List<int>();

                var frequencyMap = _numbers.GroupBy(n => n)
                                           .ToDictionary(g => g.Key, g => g.Count());

                int maxFrequency = frequencyMap.Values.Max();

                // Return the list of numbers that appear most frequently (mode)
                return frequencyMap.Where(pair => pair.Value == maxFrequency)
                                   .Select(pair => pair.Key)
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
                if (value < 0 || value > N) throw new ArgumentException("R must be between 0 and N.");
                _r = value;
            }
        }

        // Permutation calculation: P(N, R) = N! / (N - R)!
        public long Permutation => Factorial(N) / Factorial(N - R);

        // Factorial calculation: Helper method for Permutation
        private long Factorial(int num)
        {
            if (num == 0 || num == 1) return 1;

            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
