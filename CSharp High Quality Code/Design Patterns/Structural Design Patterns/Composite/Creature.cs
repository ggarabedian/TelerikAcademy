namespace Composite
{
    using System;

    public class Creature : Unit
    {
        public Creature(string name, int quantity)
            : base(name)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; set; }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + this.Name + ": " + this.Quantity);
        }
    }
}
