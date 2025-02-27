namespace LinearEquationFormula
{
    public class LinearEquation
    {
        public double Slope { get; set; }
        public double Intercept { get; set; }

        public LinearEquation(double slope, double intercept)
        {
            Slope = slope;
            Intercept = intercept;
        }


        public double CalculateY(double x)
        {
            return Slope * x + Intercept;
        }
    }
}