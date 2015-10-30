namespace CreationalPatterns.FactoryPattern.Units
{
    using System;

    public class Dragoon : Unit
    {
        public int Shield { get; set; }

        public Dragoon()
        {
            this.Name = "Dragoon";
            this.Health = 120;
            this.Armor = 3;
            this.Shield = 80;
            this.Damage = 20;
            this.Speed = 8;
            this.Range = 4;
        }

        public override void OnSpawn()
        {
            Console.WriteLine("I have returned");
        }
    }
}
