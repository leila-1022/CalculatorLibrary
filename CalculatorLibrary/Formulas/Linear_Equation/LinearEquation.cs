using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Formulas.Linear_Equation
{
    public class LinearEquation
    {
        public int M_Slope { get; set; }
        public int C_Intercept { get; set; }
        public int X_Coordinate { get; set; }
        private int _y { get; set; }

        public int Y_Coordinate
        {
            get
            {
                return _y = M_Slope * X_Coordinate + C_Intercept;
            }
            set => _y = value;

        }
    }
}
