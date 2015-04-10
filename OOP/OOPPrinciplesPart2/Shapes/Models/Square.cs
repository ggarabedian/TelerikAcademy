namespace Shapes.Models
{
    public class Square : Shape
    {
        public Square(double side)
            : base(side, side)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Width);
        }

        public override string ToString()
        {
            return string.Format("I am a square, my side is {0} and my area is ", this.Width);
        }
    }
}
