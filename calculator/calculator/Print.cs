using System;


namespace calculator
{
    class Print
    {
        public static void PrintText(string Text)
        {
           Console.WriteLine(Text);
            
        }

        public static void PrintText(string Text, double Result)
        {
            Console.WriteLine(Text + Result);
           
        }
    }
}
