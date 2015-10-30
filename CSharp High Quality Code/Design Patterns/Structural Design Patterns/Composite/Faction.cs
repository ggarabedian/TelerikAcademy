namespace Composite
{
    using System;
    using System.Collections.Generic;

    public class Faction : Unit
    {
        private readonly ICollection<Unit> creatures;

        public Faction(string name)
            : base(name)
        {
            this.creatures = new List<Unit>();
        }

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
            Console.WriteLine(new string(' ', depth) + "Faction: " + this.Name);

            foreach (var person in this.creatures)
            {
                person.Display(depth + 4);
            }
        }
    }
}
