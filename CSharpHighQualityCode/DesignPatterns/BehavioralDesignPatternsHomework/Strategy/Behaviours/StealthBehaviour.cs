namespace Strategy
{
    using System;

    public class StealthBehaviour : IBehaviour
    {
        public void Scout()
        {
            Console.WriteLine(" is scouting in stealth mode. Will follow enemy and avoid detection as long as possible!");
        }
    }
}
