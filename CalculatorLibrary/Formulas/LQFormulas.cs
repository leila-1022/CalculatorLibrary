using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas
{
    public class LQFormulas
    {
        public double slope;
        public double intercept;
        public double x;
        public double linear
        {
            get
            {
                double y = (slope * x) + intercept;
                return y;
            }
        }
    }
}
