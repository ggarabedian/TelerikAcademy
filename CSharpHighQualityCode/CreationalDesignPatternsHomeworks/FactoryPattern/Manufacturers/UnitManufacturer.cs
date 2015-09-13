namespace CreationalPatterns.FactoryPattern.Manufacturers
{
    using CreationalPatterns.FactoryPattern.Units;

    public abstract class UnitManufacturer
    {
        public abstract Unit ManufactureMeleeUnit();

        public abstract Unit ManufactureRangedUnit();
    }
}
