using System;
namespace calculator
{
    public class Program
    {

        static void Main(string[] args)
        {


            bool reset = true; // Loop condition.


            while (reset)  // Loop for restarting calculator.
            {


                //Instantiate classes And interface.
                InputProcessor Process = new InputProcessor();
                InputGetterInterface inputGetter;

                // Asking for the location of the equation(s). Storing input into string variable method.
                Console.WriteLine("Equation(s) location. Text of Console?");
                string method = Console.ReadLine().ToLower();

                //Assigning the right input location based on user's input Retrieving equation(s) and inserting into variable.
                if (method == "text")
                {
                    inputGetter = new TextFileInput();
                }
                else if (method == "console")
                {
                    inputGetter = new ConsoleInput();
                }
                else
                {
                    Console.WriteLine("Wrong input type, try again");
                    continue;
                }

                //Storing equation(s) into array. Looping through each equation.
                string[] TextInputs = inputGetter.GetInput();
                foreach (string textInput in TextInputs)
                {
                    string userInput = Process.RemoveSpaces(textInput);// Function for removing whitespaces in equation(s).
                    if (Process.ValidateInput(userInput).Success) // Check if input is valid, no letters and minimum of 3 characters.
                    {
                        Calculator Calculation = new Calculator();//Instantiate Calculator class.
                        string GetOp = Process.GetOperator(userInput); // Retrieving the operator used in the user's equation(s).
                        double[] outputs = Process.SplitInputOnOperator(userInput, GetOp); // Retrieving the numbers used in the user's equation(s).
                        double Result = Calculation.Calculate(GetOp, outputs[0], outputs[1]); // Using the operator to create the right equation and returning the answer(s).
                        Print.PrintText("answer is: ", Result); // Print the result;

                    }
                    else
                    {
                        Print.PrintText("Invalid input! Use the format (number - operator - number)");
                        Print.PrintText("Press enter to restart");
                        Console.ReadKey();
                    }
                }


                Console.ReadKey();

            }
        }
    }
}
