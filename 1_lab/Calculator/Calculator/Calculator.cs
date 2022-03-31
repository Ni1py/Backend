namespace Calculator
{
    class Calculator
    {
        public static double PerformCalculation(double num1, double num2, string ch)
        {
            double result = double.NaN;

            switch (ch)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
