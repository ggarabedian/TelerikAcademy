namespace Composite
{
    using System;
    using System.Collections.Generic;

    public class Hero : Unit
    {
        private readonly ICollection<Unit> creatures;

        public Hero(string name, int level)
            : base(name)
        {
            this.creatures = new List<Unit>();
            this.Level = level;
        }

        public int Level { get; set; }

        public void Add(Unit creature)
        {
            this.creatures.Add(creature);
        }

        public void Remove(Unit creature)
        {
            this.creatures.Remove(creature);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + "Hero: " + this.Name + " / Level: " + this.Level);

            foreach (var person in this.creatures)
            {
                person.Display(depth + 4);
            }
        }
    }
}
