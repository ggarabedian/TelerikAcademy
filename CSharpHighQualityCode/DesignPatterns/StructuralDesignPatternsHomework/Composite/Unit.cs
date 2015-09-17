namespace Composite
{
    public abstract class Unit
    {
        protected Unit(string name)
        {
            this.Name = name;
        }

        protected string Name { get; private set; }

        public abstract void Display(int depth);
    }
}
