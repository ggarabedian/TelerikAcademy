namespace CreationalPatterns.FactoryPattern.Units
{
    using System;

    public class Marine : Unit
    {
        public Marine()
        {
            this.Name = "Marine";
            this.Health = 60;
            this.Armor = 3;
            this.Damage = 7;
            this.Speed = 8;
            this.Range = 4;
        }

        public override void OnSpawn()
        {
            Console.WriteLine("You wanna piece of me, boy?");
        }
    }
}
