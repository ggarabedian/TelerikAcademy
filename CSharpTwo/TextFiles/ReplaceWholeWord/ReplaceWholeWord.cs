using System;
using System.IO;
using System.Text.RegularExpressions;

/*
Modify the solution of the previous problem to replace only whole words (not strings).
*/

class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../OriginalText.txt");
        StreamWriter writer = new StreamWriter("../../ReplacedText.txt");

        //var input = new StreamReader("input.txt");
        string text = string.Empty;
        using (reader)
        {
            text = input.ReadToEnd();
            text = text.Replace(" start ", " finish ");
        }
        //var output = new StreamWriter("output.txt");
        using (writer)
        {
            output.Write(text);
        }
    }
}

