using System;

/*
Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
*/

class CheckForPlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = 0;
        bool isNumber= Int32.TryParse(input, out number);

        if (isNumber == true && number > 1  && number < 11)
        {
            Console.WriteLine("yes");
        }
        else if ((isNumber == false) && (input == "J" || input == "Q" || input == "K" || input == "A"))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
