using System;

class DrunkenNumbers
{
    static void Main()
    {
        int roundsCount = int.Parse(Console.ReadLine());

        string winner = "";

        long mitkoDrank = 0;
        long vladkoDrank = 0;

        long beerDrank = 0;

        for (int i = 0; i < roundsCount; i++)
        {
            long curElement = long.Parse(Console.ReadLine());

            if (curElement < 0)
            {
                curElement = -curElement;
            }

            int length = curElement.ToString().Length;

            if (length % 2 == 0)
            {
                for (int j = 0; j < length / 2; j++)
                {
                    vladkoDrank += (curElement % 10);
                    curElement /= 10;
                }
                for (int j = 0; j < length / 2; j++)
                {
                    mitkoDrank += (curElement % 10);
                    curElement /= 10;
                }
            }
            else
            {
                for (int j = 0; j < length / 2; j++)
                {
                    vladkoDrank += (curElement % 10);
                    curElement /= 10;
                }

                vladkoDrank += curElement % 10; ;
                mitkoDrank += curElement % 10; ;
                curElement /= 10;

                for (int j = 0; j < length / 2; j++)
                {
                    mitkoDrank += (curElement % 10);
                    curElement /= 10;
                }
            }
            
        }

        if (mitkoDrank > vladkoDrank)
        {
            winner = "M";
            beerDrank = mitkoDrank - vladkoDrank;
        }
        else if (vladkoDrank > mitkoDrank)
        {
            winner = "V";
            beerDrank = vladkoDrank - mitkoDrank;
        }
        else if (vladkoDrank == mitkoDrank)
        {
            winner = "No";
            beerDrank = mitkoDrank + vladkoDrank;
        }

        Console.WriteLine("{0} {1}", winner, beerDrank);

    }
}


