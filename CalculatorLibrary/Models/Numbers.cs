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
        public double Average()
        {
            if (ListOfNumbers.Count == 0)
                return 0; 
            double sum = 0;
            foreach (var num in ListOfNumbers)
            {
                sum += num;
            }
            return sum / ListOfNumbers.Count;
        }
    }
}

