namespace StudentClass
{
    using System;

    using Models;

    public class Test
    {
        static void Main()
        {
            Student jim = new Student("Jim", "Marshall", "Raynor", 1234567890, "Auir", "141235123",
                                      "KillingZergs@freeTerrans.com", "101", Student.Universities.TheBlowStuffUpUniversity,
                                      Student.Specialties.Soldier, Student.Faculties.Warfare);

            Student sara = new Student("Sara", "QueenOfBlades", "Kerigan", 0987654321, "Char", "658479546",
                                      "MengskMustDie@zergQueen.com", "102", Student.Universities.TheCreateProblemsUniversity,
                                      Student.Specialties.Soldier, Student.Faculties.Warfare);

            Console.WriteLine(jim);
            Console.WriteLine(sara);
            Console.WriteLine(jim == sara);
            Console.WriteLine(jim != sara);
            Console.WriteLine(jim.Equals(sara));
            Console.WriteLine(jim.GetHashCode());
            Console.WriteLine(sara.GetHashCode());
        }
    }
}
