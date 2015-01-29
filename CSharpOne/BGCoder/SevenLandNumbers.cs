using System;

class SevenLandNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int fourthNumber = input % 10;
        int thirdNumber = (input / 10) % 10;
        int secondNumber = (input / 100) % 10;
        int firstNumber = (input / 1000) % 10;

        int result = 0;

        fourthNumber++;

        if (fourthNumber == 7)
        {
            fourthNumber = 0;
            thirdNumber++;
            if (thirdNumber == 7)
	        {
                thirdNumber = 0;
                secondNumber++;
                if (secondNumber == 7)
                {
                    secondNumber = 0;
                    firstNumber++;
                }
	        }
        }

        result = fourthNumber + thirdNumber * 10 + secondNumber * 100 + firstNumber * 1000;
        Console.WriteLine(result);
    }
}

