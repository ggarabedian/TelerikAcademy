namespace ComparingSimpleMath
{
    using System;
    using System.Diagnostics;

    public class PerformanceComparator
    {
        public const int INTEGER_VALUE = 1;
        public const long LONG_VALUE = 1;
        public const float FLOAT_VALUE = 1.0f;
        public const double DOUBLE_VALUE = 1.0d;
        public const decimal DECIMAL_VALUE = 1.0m;
        public const int REPEATS_COUNT = 1000000;

        public static void ComparePerformance(Operations operation)
        {
            TimeSpan[] timers = new TimeSpan[5];
            Stopwatch stopwatch = new Stopwatch();

            int integerResult = INTEGER_VALUE;

            stopwatch.Start();

            for (int i = 0; i < REPEATS_COUNT; i++)
            {
                switch (operation)
                {
                    case Operations.Addition:
                        integerResult += INTEGER_VALUE; 
                        break;
                    case Operations.Subtraction:
                        integerResult -= INTEGER_VALUE; 
                        break;
                    case Operations.Multiplication:
                        integerResult *= INTEGER_VALUE; 
                        break;
                    case Operations.Division:
                        integerResult /= INTEGER_VALUE; 
                        break;
                }
            }

            stopwatch.Stop();
            timers[0] = stopwatch.Elapsed;
            stopwatch.Reset();

            long longResult = LONG_VALUE;

            stopwatch.Start();

            for (int i = 0; i < REPEATS_COUNT; i++)
            {
                switch (operation)
                {
                    case Operations.Addition:
                        longResult += LONG_VALUE; 
                        break;
                    case Operations.Subtraction:
                        longResult -= LONG_VALUE; 
                        break;
                    case Operations.Multiplication:
                        longResult *= LONG_VALUE; 
                        break;
                    case Operations.Division:
                        longResult /= LONG_VALUE; 
                        break;
                }
            }

            stopwatch.Stop();
            timers[1] = stopwatch.Elapsed;
            stopwatch.Reset();

            float floatResult = FLOAT_VALUE;

            stopwatch.Start();

            for (int i = 0; i < REPEATS_COUNT; i++)
            {
                switch (operation)
                {
                    case Operations.Addition:
                        floatResult += FLOAT_VALUE; 
                        break;
                    case Operations.Subtraction:
                        floatResult -= FLOAT_VALUE; 
                        break;
                    case Operations.Multiplication:
                        floatResult *= FLOAT_VALUE; 
                        break;
                    case Operations.Division:
                        floatResult /= FLOAT_VALUE; 
                        break;
                }
            }

            stopwatch.Stop();
            timers[2] = stopwatch.Elapsed;
            stopwatch.Reset();

            double doubleResult = DOUBLE_VALUE;

            stopwatch.Start();

            for (int i = 0; i < REPEATS_COUNT; i++)
            {
                switch (operation)
                {
                    case Operations.Addition:
                        doubleResult += DOUBLE_VALUE; 
                        break;
                    case Operations.Subtraction:
                        doubleResult -= DOUBLE_VALUE; 
                        break;
                    case Operations.Multiplication:
                        doubleResult *= DOUBLE_VALUE; 
                        break;
                    case Operations.Division:
                        doubleResult /= DOUBLE_VALUE; 
                        break;
                }
            }

            stopwatch.Stop();
            timers[3] = stopwatch.Elapsed;
            stopwatch.Reset();

            decimal decimalResult = DECIMAL_VALUE;

            stopwatch.Start();

            for (int i = 0; i < REPEATS_COUNT; i++)
            {
                switch (operation)
                {
                    case Operations.Addition:
                        decimalResult += DECIMAL_VALUE; 
                        break;
                    case Operations.Subtraction:
                        decimalResult -= DECIMAL_VALUE; 
                        break;
                    case Operations.Multiplication:
                        decimalResult *= DECIMAL_VALUE; 
                        break;
                    case Operations.Division:
                        decimalResult /= DECIMAL_VALUE; 
                        break;
                }
            }

            stopwatch.Stop();
            timers[4] = stopwatch.Elapsed;

            PrintResult(operation.ToString(), timers);
        }

        public static void PrintResult(string operation, TimeSpan[] timers)
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Compare Performance of " + operation);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Int:     " + timers[0]);
            Console.WriteLine("Long:    " + timers[1]);
            Console.WriteLine("Float:   " + timers[2]);
            Console.WriteLine("Double:  " + timers[3]);
            Console.WriteLine("Decimal: " + timers[4]);
            Console.WriteLine();
        }
    }
}
