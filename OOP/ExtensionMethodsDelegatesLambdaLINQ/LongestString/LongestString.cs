namespace LongestString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        static void Main()
        {
            string[] arrayOfWords = new string[] 
            { 
                "tiger is jumping", 
                "rabbit is farming", 
                "donkey is sad", 
                "bear is eating", 
                "piglet is afraid", 
                "owl is sleeping", 
                "bee is stinging"
            };

            string longestString = arrayOfWords.OrderByDescending(str => str.Length).First();

            Console.WriteLine("\"{0}\" is the longest string in the array.", longestString);
        }
    }
}
