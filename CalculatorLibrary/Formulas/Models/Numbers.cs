using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Models
{
    public class Numbers
    {
        public List<int> ListOfNumbers { get; set; }

        public double Average { get; set; }

        public double Median { get; set; }

        public double Mean { get; set; }

        public int Mode { get; set; }
    }
}
