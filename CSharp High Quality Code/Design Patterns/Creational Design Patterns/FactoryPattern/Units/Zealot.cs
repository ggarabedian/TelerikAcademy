namespace CreationalPatterns.FactoryPattern.Units
{
    using System;

    public class Zealot : Unit  // Have to make a class with the race variables, but i'm lazy
    {
        public int Shield { get; set; }

        public Zealot()
        {
            this.Name = "Zealot";
            this.Health = 100;
            this.Armor = 3;
            this.Shield = 100;
            this.Damage = 15;
            this.Speed = 10;
            this.Range = 1;
        }

        public override void OnSpawn()
        {
            Console.WriteLine("My life for Aiur");
        }
    }
}
