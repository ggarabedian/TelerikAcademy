using System;

/*
Extend the previous program to support also subtraction and multiplication of polynomials.
*/

class SubtractingPolynomials
{
    static void Main()
    {
        Console.Write("Enter the first coefficients separated by space (a/x/x^2 order): ");
        string firstInput = Console.ReadLine();
        Console.Write("Enter the second coefficients separated by space (a/x/x^2 order): ");
        string secondInput = Console.ReadLine();

        string[] firstPoly = firstInput.Split();
        string[] secondPoly = secondInput.Split();

        int[] intFirstPoly = StringToIntArray(firstPoly);
        int[] intSecondPoly = StringToIntArray(secondPoly);
        
        Console.Write("The first polynomial: ");
        PrintPolynomial(intFirstPoly);
        Console.Write("The second polynomial: ");
        PrintPolynomial(intSecondPoly);
        Console.Write("New polynomial after addition: ");
        PrintPolynomial(PolynomialsAddition(intFirstPoly, intSecondPoly));
        Console.Write("New polynomial after subtraction: ");
        PrintPolynomial(PolynomialsSubtraction(intFirstPoly, intSecondPoly));
        Console.Write("New polynomial after multiplication: ");
        PrintPolynomial(PolynomialsMultiplication(intFirstPoly, intSecondPoly));
    }

    static int[] StringToIntArray(string[] arr)
    {
        int[] tmpArr = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            tmpArr[i] = int.Parse(arr[i]);
        }

        return tmpArr;
    }

    static int[] PolynomialsAddition(int[] poly1, int[] poly2)
    {
        if (poly1.Length < poly2.Length)
        {
            return PolynomialsAddition(poly2, poly1);
        }

        int[] result = new int[poly1.Length];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < Math.Min(poly1.Length, poly2.Length))
            {
                result[i] = poly1[i] + poly2[i];
            }
            else
            {
                if (poly1.Length > poly2.Length)
                {
                    result[i] = poly1[i];
                }
                else
                {
                    result[i] = poly2[i];
                }
            }
        }
        return result;
    }

    static int[] PolynomialsSubtraction(int[] poly1, int[] poly2)
    {
        if (poly1.Length < poly2.Length)
        {
            return PolynomialsSubtraction(poly2, poly1);
        }

        int[] result = new int[poly1.Length];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < Math.Min(poly1.Length, poly2.Length))
            {
                result[i] = poly1[i] - poly2[i];
            }
            else
            {
                if (poly1.Length > poly2.Length)
                {
                    result[i] = poly1[i];
                }
                else
                {
                    result[i] = poly2[i];
                }
            }
        }
        return result;
    }

    static int[] PolynomialsMultiplication(int[] poly1, int[] poly2)
    {
        if (poly1.Length < poly2.Length)
        {
            return PolynomialsMultiplication(poly2, poly1);
        }

        int[] result = new int[poly1.Length];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < Math.Min(poly1.Length, poly2.Length))
            {
                result[i] = poly1[i] * poly2[i];
            }
            else
            {
                if (poly1.Length > poly2.Length)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = 0;
                }
            }
        }
        return result;
    }

    static void PrintPolynomial(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == 0)
            {
                continue;
            }
            if (i >= 0 && arr[i] > 0 && i < arr.Length - 1)
            {
                Console.Write("+ ");
            }
            if (i > 1)
            {
                if (arr[i] == 1 || arr[i] == -1)
                {
                    Console.Write("x^" + i + " ");
                }
                else
                {
                    Console.Write(arr[i] + "x^" + i + " ");
                }
            }
            else if (i == 1)
            {
                if (arr[i] == 1 || arr[i] == -1)
                {
                    Console.Write("x ");
                }
                else
                {
                    Console.Write(arr[i] + "x ");
                }
            }
            else if (i == 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

