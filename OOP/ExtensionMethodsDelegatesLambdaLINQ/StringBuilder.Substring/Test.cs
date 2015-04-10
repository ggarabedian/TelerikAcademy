/*
Implement an extension method Substring(int index, int length) for the class StringBuilder that 
returns new StringBuilder and has the same functionality as Substring in the class String.
*/

namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public class Test
    {
        static void Main()
        {
            StringBuilder someText = new StringBuilder("Welcome back!");

            StringBuilder partOfTheText = someText.Substring(2, 8);

            Console.WriteLine(partOfTheText.ToString());
            
        }
    }
}
