namespace Strategy
{
    using System;

    public class RetreatBehaviour : IBehaviour
    {
        public void Scout()
        {
            Console.WriteLine(" is scouting in retreat mode. Will retreat back to town if enemy is detected!");
        }
    }
}
