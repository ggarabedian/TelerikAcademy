namespace Strategy
{
    using System;

    public class DefensiveBehaviour : IBehaviour
    {
        public void Scout()
        {
            Console.WriteLine(" is scouting in defensive mode. Will not engage, but defend itself if attacked!");
        }
    }
}
