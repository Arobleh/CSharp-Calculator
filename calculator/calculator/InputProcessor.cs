using System;
using System.Text.RegularExpressions;

namespace calculator
{
    class InputProcessor
    {
        // Splitting numbers from equation.
        public double[] SplitInputOnOperator(string UserInput, string UserOperator)
        {
            
            string[] splitting = UserInput.Split(UserOperator.ToCharArray()[0]);
            double input1 = Convert.ToDouble(splitting[0]);
            double input2 = Convert.ToDouble(splitting[1]);
            double[] inputs = { input1, input2 };

            return inputs;

        }

        // Method for finding operator and creating variable with same value.
        public string GetOperator(string userInput)
        {
            string InputOperator = Regex.Replace(userInput, @"[\d]", string.Empty);

            return InputOperator;
        }

        // Validating user's input based on specific pattern and remove white spaces in the equation.
        public Match ValidateInput(string userInput)
        {
            Match check = Regex.Match(userInput, @"\d(\+|-|\/|x|X)\d");
            return check;
        }
        //Remove whitespaces from user's input.
        public string RemoveSpaces(string UserInput)
        {
            string equation = Regex.Replace(UserInput, @"\s+", "");
            return equation;
        }
    }
}
