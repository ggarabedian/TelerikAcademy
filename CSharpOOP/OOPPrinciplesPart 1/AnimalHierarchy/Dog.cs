namespace AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, GenderType gender)
            : base(name, age, gender)
        {
            this.TypeOfAnimal = AnimalType.Dog;
        }

        public override string ProduceSound()
        {
            return "Bau.. Bau.. Grrrrrr..";
        }
    }
}
