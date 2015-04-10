using System;

/*
Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter signed short number: ");
        short number = short.Parse(Console.ReadLine());
        string result = "";

        if (number < 0)
        {
            result = "1" + ConvertShortToBinary((short)(32768 + number)).PadLeft(15, '0');
        }           
        else
        {
            result = ConvertShortToBinary(number).PadLeft(16, '0');
        }
            
        Console.WriteLine(result);
    }

    static string ConvertShortToBinary(short number)
    {
        string result = "";
        while (number > 0)
        {
            result = (number % 2).ToString() + result;
            number = (short)(number / 2);
        }
        return result;
    }

}

