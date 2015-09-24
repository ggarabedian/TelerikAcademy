namespace Strategy
{
    using System;

    public class Unit
    {
        private readonly IBehaviour behaviour;
        private readonly string name;

        public Unit(string name, IBehaviour behaviour)
        {
            this.name = name;
            this.behaviour = behaviour;
        }

        public void Scout()
        {
            Console.Write(this.name);
            behaviour.Scout();
        }
    }
}
