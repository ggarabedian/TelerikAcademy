namespace CreationalPatterns
{
    using System;

    using FactoryPattern.Manufacturers;
    using Builder.Director;
    using Builder.Builders;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Factory Pattern Example");
            Console.WriteLine(new string('*', 40));
            SpawnUnit(new TerranBarracks());
            Console.WriteLine(new string('*', 40));
            SpawnUnit(new ProtossGateway());

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Builder Pattern Example");
            Console.WriteLine(new string('*', 40));
            ConstructComputer();
        }

        private static void SpawnUnit(UnitManufacturer unitManufacturer)
        {
            var meleeUnit = unitManufacturer.ManufactureMeleeUnit();
            Console.WriteLine(meleeUnit.ToString());
            meleeUnit.OnSpawn();
            Console.WriteLine(new string('-', 20));
            var rangedUnit = unitManufacturer.ManufactureRangedUnit();
            Console.WriteLine(rangedUnit.ToString());
            rangedUnit.OnSpawn();
        }

        private static void ConstructComputer()
        {
            IComputerDirector constructor = new ComputerConstructor();

            ComputerBuilder builder = new PersonalComputerBuilder();
            constructor.Construct(builder);
            builder.Computer.Show();

            builder = new LaptopBuilder();
            constructor.Construct(builder);
            builder.Computer.Show();
        }
    }
}
