

namespace calculator
{
    class Calculator
    {
        public double Calculate(string operationInput, double input1, double input2)
        {

            double result = 0;
            switch (operationInput)
            {
                case "+":
                    result = Add(input1, input2);
                    return result;
                    break;
                case "-":
                    result = Subtract(input1, input2);
                    return result;
                    break;
                case "/":
                    result = Divide(input1, input2);
                    return result;
                    break;
                case "x":
                    result = Multiply(input1, input2);
                    return result;
                    break;
                default:
                    return result;
                    break;
                    
            }
            
        }

        public double Add(double LDigit, double RDigit)
        {
            return LDigit + RDigit;
        }

        public double Subtract(double LDigit, double RDigit) {

            return LDigit - RDigit;
        }

        public double Divide(double LDigit, double RDigit)
        {

            return LDigit / RDigit;
        }

        public double Multiply(double LDigit, double RDigit)
        {

            return LDigit * RDigit;
        }
    }
}
