namespace Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        static System.Timers.Timer timer;

        public delegate void TimerDelegate();

        private TimerDelegate timerDelegate;

        public Timer(int timeInterval)
        {
            timer = new System.Timers.Timer(timeInterval * 1000);
        }

        public void Start()
        {
            timer.Start();
            timer.Elapsed += timer_Elapsed;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (timerDelegate != null)
            {
                timerDelegate();
            }
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void AddDelegate(TimerDelegate dlgt)
        {
            timerDelegate += dlgt;
        }
    }
}