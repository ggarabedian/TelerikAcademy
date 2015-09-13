namespace CreationalPatterns.Builder.Director
{
    using CreationalPatterns.Builder.Builders;

    public interface IComputerDirector
    {
        void Construct(ComputerBuilder vehicleBuilder);
    }
}
