namespace CreationalPatterns.FactoryPattern.Manufacturers
{
    using System;
    using CreationalPatterns.FactoryPattern.Units;

    public class TerranBarracks : UnitManufacturer
    {
        public override Unit ManufactureMeleeUnit()
        {
            var firebat = new Firebat();
            return firebat;
        }

        public override Unit ManufactureRangedUnit()
        {
            var marine = new Marine();
            return marine;
        }
    }
}
