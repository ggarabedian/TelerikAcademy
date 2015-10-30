namespace CreationalPatterns.FactoryPattern.Units
{
    using System;

    public class Firebat : Unit
    {
        public Firebat()
        {
            this.Name = "Firebat";
            this.Health = 80;
            this.Armor = 3;
            this.Damage = 20;
            this.Speed = 8;
            this.Range = 2;
        }

        public override void OnSpawn()
        {
            Console.WriteLine("Need a light?");
        }
    }
}
