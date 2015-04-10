using System;

/*
Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

class EnterNumbers
{
    static int lastNumber = int.MinValue;
    static int counter;

    static void Main()
    {
        int start = 1;
        int end = 100;

        for (counter = 0; counter < 10; counter++)
        {
            ReadNumber(start, end);
        }
    }

    static void ReadNumber(int start, int end)
    {
        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);

            if (number > start && number < end)
            {
                if (number > lastNumber)
                {
                    Console.Write("The number is between {0} and {1} and is greater than the previous!", start, end);
                    lastNumber = number;
                }
                else
                {
                    counter--;
                    throw new InvalidOperationException();
                }
            }
            else
            {
                counter--;
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number should be between {0} and {1}!", start, end);
        }

        catch (FormatException)
        {
            counter--;
            Console.WriteLine("You should enter a number!");
        }

        catch (InvalidOperationException)
        {
            Console.WriteLine("Each number has to be greater than the previous!");
        }
        Console.WriteLine();
    }
}

