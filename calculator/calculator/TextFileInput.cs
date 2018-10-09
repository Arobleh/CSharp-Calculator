using System.IO;

namespace calculator
{
    class TextFileInput : InputGetterInterface
    {
        public string[] GetInput()
        {
           return File.ReadAllLines(@"C:\Users\AminR\source\repos\calculator\equation.txt");
        }
    }
}
