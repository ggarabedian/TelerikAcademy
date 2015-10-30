using System;

namespace CreationalPatterns.Builder.Builders
{
    public class PersonalComputerBuilder : ComputerBuilder
    {
        public PersonalComputerBuilder()
        {
            this.Computer = new Computer("Personal Computer");
        }

        public override void AddCpu()
        {
            this.Computer["motherBoard"] = "ASRock";
        }

        public override void AddHdd()
        {
            this.Computer["cpu"] = "Intel Core i5";
        }

        public override void AddMotherBoard()
        {
            this.Computer["videoCard"] = "GeForce GT 740";
        }

        public override void AddVideoCard()
        {
            this.Computer["hdd"] = "Samsung 1TB";
        }
    }
}
