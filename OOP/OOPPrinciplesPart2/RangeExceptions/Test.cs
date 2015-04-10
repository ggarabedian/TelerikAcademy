namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid input! ", 1, 100);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                throw new InvalidRangeException<int>(0, 9);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
