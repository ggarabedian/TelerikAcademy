using System;
using System.Globalization;
using System.Threading;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        int fiveTray = int.Parse(Console.ReadLine());
        int tenTray = int.Parse(Console.ReadLine());
        int twentyTray = int.Parse(Console.ReadLine());
        int fiftyTray = int.Parse(Console.ReadLine());
        int hundredTray = int.Parse(Console.ReadLine());
        decimal moneyFromDev = decimal.Parse(Console.ReadLine());
        decimal coffeePrice = decimal.Parse(Console.ReadLine());
        
        decimal moneyInMachine = (decimal)(fiveTray * 0.05 + tenTray * 0.10 + twentyTray * 0.20 + fiftyTray * 0.50 + hundredTray * 1.00);

        if (moneyFromDev >= coffeePrice && (moneyFromDev - coffeePrice) <= moneyInMachine)
        {
            Console.WriteLine("Yes {0:0.00}", (moneyInMachine - (moneyFromDev - coffeePrice)));
        }
        else if (moneyFromDev >= coffeePrice && (moneyFromDev - coffeePrice) > moneyInMachine)
        {
            Console.WriteLine("No {0:0.00}", ((moneyFromDev - coffeePrice) - moneyInMachine));
        }
        else if (coffeePrice > moneyFromDev)
        {
            Console.WriteLine("More {0:0.00}", coffeePrice - moneyFromDev);
        }
    }
}

