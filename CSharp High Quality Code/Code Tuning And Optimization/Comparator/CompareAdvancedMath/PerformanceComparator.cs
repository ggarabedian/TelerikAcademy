namespace CompareAdvancedMath
{
    using System;
    using System.Diagnostics;

    public class PerformanceComparator
    {
        public const float FLOAT_VALUE = 100.0f;
        public const double DOUBLE_VALUE = 100.0d;
        public const decimal DECIMAL_VALUE = 100.0m;
        public const int REPEATS_COUNT = 1000000;

        public static void ComparePerformance(MathFunctions mathFunction)
        {
            TimeSpan[] timers = new TimeSpan[3];
            Stopwatch stopwatch = new Stopwatch();

            float floatResult = FLOAT_VALUE;

            stopwatch.Start();

            for (int i = 0; i < REPEATS_COUNT; i++)
            {
                switch (mathFunction)
                {
                    case MathFunctions.Sqrt:
                        floatResult = (float)Math.Sqrt(FLOAT_VALUE);
                        break;
                    case MathFunctions.Log:
                        floatResult = (float)Math.Log(FLOAT_VALUE);
                        break;
                    case MathFunctions.Sin:
                        floatResult = (float)Math.Sin(FLOAT_VALUE);
                        break;
                }
            }

            stopwatch.Stop();
            timers[0] = stopwatch.Elapsed;
            stopwatch.Reset();

            double doubleResult = DOUBLE_VALUE;

            stopwatch.Start();

            for (int i = 0; i < REPEATS_COUNT; i++)
            {
                switch (mathFunction)
                {
                    case MathFunctions.Sqrt:
                        doubleResult = Math.Sqrt(DOUBLE_VALUE);
                        break;
                    case MathFunctions.Log:
                        doubleResult = Math.Log(DOUBLE_VALUE);
                        break;
                    case MathFunctions.Sin:
                        doubleResult = Math.Sin(DOUBLE_VALUE);
                        break;
                }
            }

            stopwatch.Stop();
            timers[1] = stopwatch.Elapsed;
            stopwatch.Reset();

            decimal decimalResult = DECIMAL_VALUE;

            stopwatch.Start();

            for (int i = 0; i < REPEATS_COUNT; i++)
            {
                switch (mathFunction)
                {
                    case MathFunctions.Sqrt:
                        decimalResult = (decimal)Math.Sqrt((double)DECIMAL_VALUE);
                        break;
                    case MathFunctions.Log:
                        decimalResult = (decimal)Math.Log((double)DECIMAL_VALUE);
                        break;
                    case MathFunctions.Sin:
                        decimalResult = (decimal)Math.Sin((double)DECIMAL_VALUE);
                        break;
                }
            }

            stopwatch.Stop();
            timers[2] = stopwatch.Elapsed;

            PrintResult(mathFunction.ToString(), timers);
        }

        public static void PrintResult(string mathFunction, TimeSpan[] timers)
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Compare Performance of Math." + mathFunction);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Float:   " + timers[0]);
            Console.WriteLine("Double:  " + timers[1]);
            Console.WriteLine("Decimal: " + timers[2]);
            Console.WriteLine();
        }
    }
}
