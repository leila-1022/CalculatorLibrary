using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Models
{
    public class Numbers
    {
        public List<int> ListOfNumbers { get; set; }

        public decimal AverageOfNumbers => CalculateAverage();

        public decimal CalculateAverage()
        {
            if (ListOfNumbers == null || ListOfNumbers.Count == 0)
                return 0;
            return (decimal)ListOfNumbers.Average();
        }
    }
}
