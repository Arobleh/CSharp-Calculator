using System;

namespace calculator
{
    class ConsoleInput : InputGetterInterface
    {
        public string[] GetInput()
        {
            Console.WriteLine("Enter your equation");
            string input = Console.ReadLine();

            return new string[] { input };
        }
    }
}
