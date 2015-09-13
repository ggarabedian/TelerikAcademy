namespace CreationalPatterns.Builder
{
    using System;
    using System.Collections.Generic;

    public class Computer
    {
        private readonly string computerType;
        private readonly Dictionary<string, string> components = new Dictionary<string, string>();

        public Computer(string vehicleType)
        {
            this.computerType = vehicleType;
        }

        public string this[string key]
        {
            get { return this.components[key]; }
            set { this.components[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine(" Computer Type: {0}", this.computerType);
            Console.WriteLine(" MotherBoard : {0}", this["motherBoard"]);
            Console.WriteLine(" CPU: {0}", this["cpu"]);
            Console.WriteLine(" Video Card: {0}", this["videoCard"]);
            Console.WriteLine(" HDD: {0}", this["hdd"]);
            Console.WriteLine("---------------------------");
        }
    }
}
