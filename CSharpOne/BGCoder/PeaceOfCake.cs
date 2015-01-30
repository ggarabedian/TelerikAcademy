using System;

class PeaceOfCake
{
    static void Main()
    {
        decimal A = decimal.Parse(Console.ReadLine());
        decimal B = decimal.Parse(Console.ReadLine());
        decimal C = decimal.Parse(Console.ReadLine());
        decimal D = decimal.Parse(Console.ReadLine());

        decimal firstCake = A / B;
        decimal secondCake = C / D;
        decimal cakeFraction = A / B + C / D;

        if (cakeFraction > 1)
        {
            int fullCake = (int)(cakeFraction);
            Console.WriteLine(fullCake);
        }
        else
        {
            Console.WriteLine("{0:N22}", cakeFraction);
        }
        Console.WriteLine("{0}/{1}", A * D + C * B, B * D);
    }
}

