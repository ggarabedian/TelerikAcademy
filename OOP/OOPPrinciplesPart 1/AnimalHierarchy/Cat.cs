namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, GenderType gender)
            : base(name, age, gender)
        {
            this.TypeOfAnimal = AnimalType.Cat;
        }

        public override string ProduceSound()
        {
            return "Mrrrr...";
        }
    }
}
