namespace CreationalPatterns.Builder.Builders
{
    public abstract class ComputerBuilder
    {
        public Computer Computer { get; set; }

        public abstract void AddMotherBoard();

        public abstract void AddCpu();

        public abstract void AddVideoCard();

        public abstract void AddHdd();
    }
}
