namespace CreationalPatterns.FactoryPattern.Units
{
    using System.Text;

    public abstract class Unit
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }

        public int Damage { get; set; }

        public int Speed { get; set; }

        public int Range { get; set; }

        public abstract void OnSpawn();

        public override string ToString()
        {
            var unitAsString = new StringBuilder();

            unitAsString.AppendLine("Unit: " + this.Name);
            unitAsString.AppendLine("Damage: " + this.Damage);
            unitAsString.AppendLine("Speed: " + this.Speed);
            unitAsString.AppendLine("Range: " + this.Range);
            unitAsString.AppendLine("Health: " + this.Health);
            unitAsString.Append("Armor: " + this.Armor);

            return unitAsString.ToString();
        }
    }
}
