using System;

/*
Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            long input = long.Parse(Console.ReadLine());

            string result = "";
            char charElement = char.MinValue;

            while (input > 0)
            {
                long curElement = input % 16;
                if (curElement > 9)
                {
                        switch (curElement)
                    {
                        case 10: charElement = 'A'; break;
                        case 11: charElement = 'B'; break;
                        case 12: charElement = 'C'; break;
                        case 13: charElement = 'D'; break;
                        case 14: charElement = 'E'; break;
                        case 15: charElement = 'F'; break;
                    }
                        result += charElement;
                }
                else
                {
                    result += curElement.ToString();
                }
                input /= 16;
            }

            char[] temp = result.ToCharArray();
            Array.Reverse(temp);
            result = new string(temp);

            Console.WriteLine("Hexadecimal: " + result);
        }
    }

