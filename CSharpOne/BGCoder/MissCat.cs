using System;

class MissCat
{
    static void Main()
    {
        int jurySize = int.Parse(Console.ReadLine());

        int[] cats = new int[jurySize];

        int curWinner = 0;
        int counter = 0;
        int finalWinner = 0;
        int finalCounter = 0;

        for (int i = 0; i < jurySize; i++)
        {
            cats[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(cats);

        for (int i = 0; i < jurySize; i++)
        {
            if (i < jurySize - 1)
            {
                if (cats[i] == cats[i+1])
                {
                    curWinner = cats[i];
                    counter++;
                    if (counter > finalCounter)
                    {
                        finalWinner = curWinner;
                        finalCounter = counter;
                    }
                }
                else
                {   
                    curWinner = 0;
                    counter = 0;
                }
            }
        }

        if (finalCounter == 0)
        {
            Console.WriteLine(cats[0]);
        }
        else
        {
            Console.WriteLine(finalWinner);
        }

       
    }
}

