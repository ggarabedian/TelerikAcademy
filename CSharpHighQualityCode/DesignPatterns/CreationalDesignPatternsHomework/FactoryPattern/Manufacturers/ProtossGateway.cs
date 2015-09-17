namespace CreationalPatterns.FactoryPattern.Manufacturers
{
    using System;
    using CreationalPatterns.FactoryPattern.Units;

    public class ProtossGateway : UnitManufacturer
    {
        public override Unit ManufactureMeleeUnit()
        {
            var zealot = new Zealot();
            return zealot;
        }

        public override Unit ManufactureRangedUnit()
        {
            var dragoon = new Dragoon();
            return dragoon;
        }
    }
}
