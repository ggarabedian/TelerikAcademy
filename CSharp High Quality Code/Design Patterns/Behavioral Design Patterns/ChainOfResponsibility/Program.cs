namespace ChainOfResponsibility
{
    using ChainOfResponsibility.HeroSystem;
    using ChainOfResponsibility.ItemSystem;

    public class Program
    {
        public static void Main()
        {
            var harryPotter = new HarryPotter();
            var jamesPotter = new JamesPotter();
            var dumbledore = new Dumbledore();
            var gryffindor = new Gryffindor();

            harryPotter.SetSuccessor(jamesPotter);
            jamesPotter.SetSuccessor(dumbledore);
            dumbledore.SetSuccessor(gryffindor);

            harryPotter.EvaluateEquipment(new ElderWand());
            harryPotter.EvaluateEquipment(new SwordOfGryffindor());
            harryPotter.EvaluateEquipment(new InvisibilityCloak());
        }
    }
}