namespace Task_4
{
    internal class CalculatorModel
    {
        public double Plus(double a, double b)
        {
            return a + b;
        }
        
        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double? Div(double a, double b)
        {
            if (b == 0)
            {
                return null;
            }
            
            return a / b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }
    }
}
