using System;

/*
Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement. 
*/

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.Write("Please choose type - (1)int, (2)double, (3)string: ");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: 
                Console.Write("Please enter an integer number: ");
                int intInput = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(intInput);
                break;
            case 2:
                 Console.Write("Please enter a double number: ");
                double doubleInput = double.Parse(Console.ReadLine()) + 1.00;
                Console.WriteLine(doubleInput);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string stringInput = Console.ReadLine() + "*";
                Console.WriteLine(stringInput);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

    }
}

