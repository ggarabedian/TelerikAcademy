/*
Using delegates write a class Timer that can execute certain method at each t seconds.
*/

namespace Timer
{
    using System;
    using System.Threading;

    public class Test
    {
        static void Main()
        {
            Timer timer = new Timer(1);
            Timer.TimerDelegate dlgt = delegate() { Console.WriteLine(DateTime.Now); };
            timer.AddDelegate(dlgt);
            timer.Start();
            Thread.Sleep(10000);
            timer.Stop();
        }
    }
}
