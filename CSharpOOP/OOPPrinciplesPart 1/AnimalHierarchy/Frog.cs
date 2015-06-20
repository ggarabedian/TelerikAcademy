namespace AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, GenderType gender)
            : base(name, age, gender)
        {
            this.TypeOfAnimal = AnimalType.Frog;
        }

        public override string ProduceSound()
        {
            return "Kvak... Kvak...";
        }
    }
}