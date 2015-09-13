using System;

namespace CreationalPatterns.Builder.Builders
{
    public class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            this.Computer = new Computer("Laptop");
        }

        public override void AddCpu()
        {
            this.Computer["motherBoard"] = "Asus";
        }

        public override void AddHdd()
        {
            this.Computer["cpu"] = "Intel Core i3";
        }

        public override void AddMotherBoard()
        {
            this.Computer["videoCard"] = "GeForce GT 720M";
        }

        public override void AddVideoCard()
        {
            this.Computer["hdd"] = "Samsung 1TB";
        }
    }
}
