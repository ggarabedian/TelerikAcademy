namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Test
    {
        static void Main()
        {
            var tomcats = new List<Tomcat>()
            {
                new Tomcat("Felix", 6),
                new Tomcat("Garfield", 5),
                new Tomcat("Tom", 8),
                new Tomcat("Taz", 6)
            };

            var kittens = new List<Kitten>()
            {
                new Kitten("Trixie", 2),
                new Kitten("Pixie", 4),
                new Kitten("Dixie", 7),
                new Kitten("Rixie", 5)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Lassi", 9, GenderType.Female),
                new Dog("George", 7, GenderType.Male),
                new Dog("Rex", 2, GenderType.Male),
                new Dog("Jane", 6, GenderType.Female),
                new Dog("Indiana", 10, GenderType.Male),
            };

            var frogs = new List<Frog>()
            {                            
                new Frog("Jumpy", 5, GenderType.Male),
                new Frog("Greeny", 3, GenderType.Female),
                new Frog("Oldie", 9, GenderType.Male),
                new Frog("Sticky", 4, GenderType.Female),
            };

            PrintAnimals(tomcats);
            PrintAnimals(kittens);
            PrintAnimals(dogs);
            PrintAnimals(frogs);

            Console.WriteLine(new string('*', 35));

            Console.WriteLine("Tomcats average age: {0:F2}", Animal.AverageAge(tomcats));
            Console.WriteLine("Kittens average age: {0:F2}", Animal.AverageAge(kittens));
            Console.WriteLine("Dogs average age: {0:F2}", Animal.AverageAge(dogs));
            Console.WriteLine("Frogs average age: {0:F2}", Animal.AverageAge(frogs));           
        }

        public static void PrintAnimals(IEnumerable<Animal> listOfAnimals)
        {
            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
