namespace Strategy
{
    public class Program
    {
        public static void Main()
        {
            var rogue = new Unit("Rogue", new StealthBehaviour());
            var warrior = new Unit("Warrior", new AggresiveBehaviour());
            var paladin = new Unit("Paladin", new DefensiveBehaviour());
            var worker = new Unit("Worker", new RetreatBehaviour());

            rogue.Scout();
            warrior.Scout();
            paladin.Scout();
            worker.Scout();
        }
    }
}