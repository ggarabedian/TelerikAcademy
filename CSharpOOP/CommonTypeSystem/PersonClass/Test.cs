namespace PersonClass
{
    using System;
    public class Test
    {
        static void Main()
        {
            Person james = new Person("James");
            Person john = new Person("John", 32);

            Console.WriteLine(james);
            Console.WriteLine(john);
        }
    }
}
