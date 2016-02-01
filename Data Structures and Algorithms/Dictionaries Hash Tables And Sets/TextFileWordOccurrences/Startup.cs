namespace TextFileWordOccurrences
{
    using System;
    using System.IO;
    using System.Linq;

    /*
    Write a program that counts how many times each word from given text file words.txt appears in it. 
    The character casing differences should be ignored. The result words should be ordered by their number of 
    occurrences in the text. Example: This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
    is -> 2
    the -> 2
    this -> 3
    text -> 6
    */
    public class Startup
    {
        public static void Main()
        {
            string text = File.ReadAllText("../../words.txt");
            char[] splitChars = new char[] { ' ', '.', ',', '!', '–', '?' };

            var words = text
                .ToLower()
                .Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(w => w);

            foreach (var word in words)
            {
                Console.WriteLine("{0} => {1}", word.Key, word.Count());
            }
        }
    }
}
