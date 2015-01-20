using System;
using System.Globalization;
using System.Threading;

class Garden
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        decimal tomatoSeed = decimal.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        decimal cucumberSeed = decimal.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        decimal potatoSeed = decimal.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        decimal carrotSeed = decimal.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        decimal cabbageSeed = decimal.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        decimal beansSeed = decimal.Parse(Console.ReadLine());

        decimal tomatoPrice = 0.5M;
        decimal cucumberPrice = 0.4M;
        decimal potatoPrice = 0.25M;
        decimal carrotPrice = 0.6M;
        decimal cabbagePrice = 0.3M;
        decimal beansPrice = 0.4M;

        decimal totalSeedCost = 0;

        int areaUsed = 0;
        
        //Seed cost

        totalSeedCost = (tomatoSeed * tomatoPrice) + (cucumberSeed * cucumberPrice) + (potatoSeed * potatoPrice) +
                        (carrotSeed * carrotPrice) + (cabbageSeed * cabbagePrice) + (beansSeed * beansPrice);

        Console.WriteLine("Total costs: {0, 0:0.00}", totalSeedCost);

        //Area calculation

        areaUsed = 250 - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;

        if (areaUsed < 0)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (areaUsed == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Beans area: {0}", areaUsed);
        }
    }
}

