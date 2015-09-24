namespace Strategy
{
    using System;

    public class AggresiveBehaviour : IBehaviour
    {
        public void Scout()
        {
            Console.WriteLine(" is scouting in aggresive mode. Attacking enemy on sight!");
        }
    }
}
