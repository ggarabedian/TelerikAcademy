using System;
using CreationalPatterns.Builder.Builders;

namespace CreationalPatterns.Builder.Director
{
    public class ComputerConstructor : IComputerDirector
    {
        public void Construct(ComputerBuilder computerBuilder)
        {
            computerBuilder.AddMotherBoard();
            computerBuilder.AddCpu();
            computerBuilder.AddVideoCard();
            computerBuilder.AddHdd();
        }
    }
}
