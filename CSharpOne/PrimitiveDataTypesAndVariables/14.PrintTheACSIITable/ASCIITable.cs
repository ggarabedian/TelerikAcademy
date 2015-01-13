using System;

/*
Find online more information about ASCII (American Standard Code for Information Interchange) and write a 
program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
*/

class ASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine(i + "\t" +(char)i);
        }
    }
}