namespace SixtyFourBitArray
{
    using System;

    class Test
    {
        static void Main()
        {
            BitArray firstArray = new BitArray(10u);
            BitArray secondArray = new BitArray(5u);

            Console.WriteLine(firstArray);
            firstArray[5] = 1;
            Console.WriteLine(firstArray);

            Console.WriteLine(firstArray == secondArray);
            Console.WriteLine(firstArray != secondArray);
        }
    }
}
